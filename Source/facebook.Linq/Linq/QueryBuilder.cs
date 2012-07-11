using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections;
using System.Diagnostics;

namespace Facebook.Linq
{
	class FqlQueryBuilder
	{
		public FqlQueryBuilder(Expression query)
		{
			Query = query;
			QueryOptions = new QueryOptions();
		}

		public QueryOptions QueryOptions;
		public Expression Query;

		public string BuildQuery()
		{
			sb = new StringBuilder();
			Build(Query);
			var query = sb.ToString();
			return query;
		}

		#region Eval

		private object Eval(Expression exp)
		{
			switch (exp.NodeType)
			{
				case ExpressionType.MemberAccess:
					return Eval((MemberExpression)exp);
				case ExpressionType.Constant:
					return Eval((ConstantExpression)exp);
				default:
					throw new NotImplementedException();
			}
		}

		private object Eval(ConstantExpression exp)
		{
			return exp.Value;
		}

		private object Eval(MemberExpression exp)
		{
			var p = exp.Expression == null ? null : Eval(exp.Expression);
			if (exp.Member is PropertyInfo)
			{
				return ((PropertyInfo)exp.Member).GetValue(p, null);
			}
			else if (exp.Member is FieldInfo)
			{
				return ((FieldInfo)exp.Member).GetValue(p);
			}
			throw new NotImplementedException();
		}

		#endregion

		#region Build

		private void Build(object value)
		{
			if (value == null)
				throw new Exception("value is null");
			if (value is Expression)
				Build((Expression)value);
			else if (value is string)
				Build((string)value);
			else if (value is int)
				_Build((int)value);
			else if (value is long)
				_Build((long)value);
			else if (value is IFqlDataQuery)
			{
				var innerQuery = (IFqlDataQuery)value;
				var innerQueryText = innerQuery.ToString();
				if (InSelect > 0 && innerQueryText.StartsWith("from"))
				{
					Write(innerQueryText.Substring(4));
				}
				else
				{
					Write("(");
					Write(innerQueryText);//
					Write(")");
				}
			}
			else if (typeof(IEnumerable).IsAssignableFrom(value.GetType()))
			{
				var a = (IEnumerable)value;
				Write("(");
				bool first = true;
				foreach (var i in a)
				{
					if (first)
						first = false;
					else Write(",");
					Build(i);
				}
				Write(")");
			}
			else
				throw new NotImplementedException(value.GetType() + " is not a supported type");
		}

		private void Build(string literal)
		{
			sb.AppendFormat("'{0}' ", literal);
		}

		private void Build(IEnumerable<Expression> exps)
		{
			foreach (var exp in exps)
			{
				Build(exp);
			}
		}

		private void Build(Expression exp)
		{
			switch (exp.NodeType)
			{
				case ExpressionType.Call:
					_Build((MethodCallExpression)exp);
					break;
				case ExpressionType.Constant:
					_Build((ConstantExpression)exp);
					break;
				case ExpressionType.Quote:
					_Build((UnaryExpression)exp);
					break;
				case ExpressionType.Lambda:
					_Build((LambdaExpression)exp);
					break;
				case ExpressionType.NotEqual:
				case ExpressionType.Equal:
					_Build((BinaryExpression)exp);
					break;
				case ExpressionType.MemberAccess:
					_Build((MemberExpression)exp);
					break;
				case ExpressionType.Add:
					_Build((BinaryExpression)exp);
					break;
				case ExpressionType.New:
					_Build((NewExpression)exp);
					break;
				case ExpressionType.Convert:
					Build(((UnaryExpression)exp).Operand);
					break;

				case ExpressionType.AndAlso:
				case ExpressionType.OrElse:
					_Build(((BinaryExpression)exp));
					break;

				case ExpressionType.MemberInit:
					_Build(((MemberInitExpression)exp));
					break;

				case ExpressionType.AddChecked:
				case ExpressionType.And:
				case ExpressionType.ArrayIndex:
				case ExpressionType.ArrayLength:
				case ExpressionType.Coalesce:
				case ExpressionType.Conditional:
				case ExpressionType.ConvertChecked:
				case ExpressionType.Divide:
				case ExpressionType.ExclusiveOr:
				case ExpressionType.GreaterThan:
				case ExpressionType.GreaterThanOrEqual:
				case ExpressionType.Invoke:
				case ExpressionType.LeftShift:
				case ExpressionType.LessThan:
				case ExpressionType.LessThanOrEqual:
				case ExpressionType.ListInit:
				case ExpressionType.Modulo:
				case ExpressionType.Multiply:
				case ExpressionType.MultiplyChecked:
				case ExpressionType.Negate:
				case ExpressionType.NegateChecked:
				case ExpressionType.NewArrayBounds:
				case ExpressionType.NewArrayInit:
				case ExpressionType.Not:
				case ExpressionType.Or:
				case ExpressionType.Parameter:
				case ExpressionType.Power:
				case ExpressionType.RightShift:
				case ExpressionType.Subtract:
				case ExpressionType.SubtractChecked:
				case ExpressionType.TypeAs:
				case ExpressionType.TypeIs:
				case ExpressionType.UnaryPlus:
				default:
					throw new NotImplementedException(exp.NodeType + " is not supported");
			}
		}

		private void Build(MemberBinding b)
		{
			switch (b.BindingType)
			{
				case MemberBindingType.Assignment:
					{
						var ma = (MemberAssignment)b;
						Build(ma.Expression);
					}
					break;
				case MemberBindingType.ListBinding:
					throw new NotImplementedException();
				case MemberBindingType.MemberBinding:
					throw new NotImplementedException();
			}
		}

		private void _Build(MemberInitExpression exp)
		{
			var first = true;
			foreach (var b in exp.Bindings)
			{
				if (first)
					first = false;
				else Write(",");
				Build(b);
			}
		}
		
		private void _Build(MethodCallExpression exp)
		{
			if (exp.Method.Name == "Where")
			{
				bool nestedWhere = (IsMethodCall(exp.Arguments[0], "Where"));

				if (InSelect == 0 && !nestedWhere) //No projection has been specified, and we're in a Where clause (hence select * is assumed)
				{
					Write("from");
				}
				Build(exp.Arguments[0]);

				if (nestedWhere)
				{
					//Nested where
					Write("AND");
				}
				else
				{
					Write("where");
				}
				Build(exp.Arguments[1]);
			}
			else if (exp.Method.Name == "Select")
			{
				InSelect++;
				if (!HasSelect)
				{
					HasSelect = true;
					QueryOptions.Select = ((UnaryExpression)exp.Arguments[1]).Operand;
				}
				Write("select");
				Build(exp.Arguments[1]);
				Write("from");
				Build(exp.Arguments[0]);
				InSelect--;
			}
			else if (exp.Method.Name == "Contains")
			{
				Build(exp.Arguments[1]);
				Write("in");
				string innerQuery = new FqlQueryBuilder(exp.Arguments[0]).BuildQuery().Trim();
				if (!innerQuery.StartsWith("("))
					innerQuery = "(" + innerQuery + ")";
				Write(innerQuery);
			}
			else if (exp.Method.Name == "Take")
			{
				bool hasSkip = ((exp.Arguments[0] is MethodCallExpression) && (((((MethodCallExpression)(exp.Arguments[0])).Method)).Name == "Skip"));
				if (hasSkip)
				{
					Build((exp.Arguments[0] as MethodCallExpression).Arguments[0]);
				}
				else
				{
					Build(exp.Arguments[0]); // no skip specified
				}
				Write("limit ");
				Build(exp.Arguments[1]); //Take and Skip are used together, and in FQL / MySQL syntax 
				if (hasSkip)
				{
					Write("offset ");
					Build((exp.Arguments[0] as MethodCallExpression).Arguments[1]);
				}
			}
			else if (exp.Method.Name == "Skip")
			{
				throw new Exception("Cannot use Skip without Take");
				//Build(exp.Arguments[0]);
				//Write("offset ");
				//Build(exp.Arguments[1]);
			}
			else if (exp.Method.Name == "First" || exp.Method.Name == "FirstOrDefault")
			{
				Build(exp.Arguments[0]);
				Write("limit 1");
			}
			else if (exp.Method.Name == "OrderBy")
			{
				Build(exp.Arguments[0]);
				Write("order by ");
				Build(exp.Arguments[1]);
			}
			else if (exp.Method.Name == "OrderByDescending")
			{
				Build(exp.Arguments[0]);
				Write("order by ");
				Build(exp.Arguments[1]);
				Write("DESC");
			}
			else if (exp.Method.Name == "ThenBy")
			{
				throw new NotImplementedException("ThenBy is not supported by FQL.  Use a calculated key in the OrderBy clause");
				//Build(exp.Arguments[0]);
				//var desc = "";
				//if (sb.ToString().EndsWith("DESC "))
				//{
				//  sb.Length -= 6;
				//  desc = "DESC";
				//}
				//Write(",");
				//Build(exp.Arguments[1]);
				//sb.Append(desc);
			}
			else if (exp.Method.Name == "Count")
			{
				Build(exp.Arguments[0]);
				QueryOptions.IsCount = true;
				QueryOptions.Select = null; //No need to select when performing Count()
				if (sb.ToString().StartsWith("from"))
				{
					sb.Insert(0, "select '' ");
				}
				else if (sb.ToString().StartsWith("select"))
				{
					var s = sb.ToString();
					var idx = s.IndexOf("from");
					sb.Length = 0;
					sb.Append("select '' ");
					sb.Append(s.Substring(idx));
				}
			}
			else
				throw new Exception();
		}

		private void _Build(NewExpression exp)
		{
			bool first = true;
			foreach (var arg in exp.Arguments)
			{
				if (first)
					first = false;
				else
					Write(",");
				Build(arg);
			}
		}

		private void _Build(MemberExpression exp)
		{
			var member = exp.Member;
			var memberType = ReflectionHelper.GetMemberType(member);
			if (typeof(IFqlDataQuery).IsAssignableFrom(memberType)) //Query
			{
				if (exp.Expression is ConstantExpression)
				{
					var obj = ((ConstantExpression)(exp.Expression)).Value;
					var value = ReflectionHelper.GetMemberValue(member, obj);
					Build(value);
				}
				else
					throw new NotSupportedException();
			}
			else if (typeof(IFqlTable).IsAssignableFrom(memberType)) //Table
			{
				var tableRowType = ((PropertyInfo)exp.Member).PropertyType.GetGenericArguments()[0];
				var td = KnownTypeData.GetTypeData(tableRowType);
				var tblName = GetTableName(td);
				Write(tblName);
			}
			else //Column
			{
				var memberName = exp.Member.Name;
				var td = KnownTypeData.GetTypeData(exp.Member.DeclaringType);
				if (exp.Member.Name == "Me")
				{
					Write("me()");
				}
				else if (td.Properties.ContainsKey(memberName))
				{
					var pd = td.Properties[exp.Member.Name];
					Write(pd.FqlFieldName);
				}
				else //Variable
				{
					var value = Eval(exp);
					Build(value);
				}
			}
		}

		private void _Build(BinaryExpression exp)
		{
			Build(exp.Left);
			switch (exp.NodeType)
			{
				case ExpressionType.Add:
					Write("+");
					break;
				case ExpressionType.Subtract:
					Write("-");
					break;
				case ExpressionType.AndAlso:
					Write("AND");
					break;
				case ExpressionType.Equal:
					Write("=");
					break;
				case ExpressionType.OrElse:
					Write("OR");
					break;
				case ExpressionType.LessThan:
					Write("<");
					break;
				case ExpressionType.LessThanOrEqual:
					Write("<=");
					break;
				case ExpressionType.GreaterThan:
					Write(">");
					break;
				case ExpressionType.GreaterThanOrEqual:
					Write(">=");
					break;
				case ExpressionType.Modulo:
					Write("%");
					break;
				case ExpressionType.Multiply:
					Write("*");
					break;
				case ExpressionType.NotEqual:
					Write("<>");
					break;
				case ExpressionType.AddChecked:
				case ExpressionType.And:
				case ExpressionType.ArrayIndex:
				case ExpressionType.ArrayLength:
				case ExpressionType.Coalesce:
				case ExpressionType.Conditional:
				case ExpressionType.Convert:
				case ExpressionType.ConvertChecked:
				case ExpressionType.Divide:
				case ExpressionType.ExclusiveOr:
				case ExpressionType.Invoke:
				case ExpressionType.Lambda:
				case ExpressionType.LeftShift:				
				case ExpressionType.ListInit:
				case ExpressionType.MultiplyChecked:
				case ExpressionType.Negate:
				case ExpressionType.NegateChecked:
				case ExpressionType.New:
				case ExpressionType.NewArrayBounds:
				case ExpressionType.NewArrayInit:
				case ExpressionType.Not:
				case ExpressionType.Or:
				case ExpressionType.Parameter:
				case ExpressionType.Power:
				case ExpressionType.Quote:
				case ExpressionType.RightShift:
				case ExpressionType.SubtractChecked:
				case ExpressionType.TypeAs:
				case ExpressionType.TypeIs:
				case ExpressionType.UnaryPlus:
				default:
					throw new NotImplementedException();
			}
			Build(exp.Right);
		}

		private void _Build(LambdaExpression exp)
		{
			Build(exp.Body);
		}

		private void _Build(UnaryExpression exp)
		{
			Build(exp.Operand);
		}

		private void _Build(ConstantExpression exp)
		{
			var value = exp.Value;
			var type = value.GetType();
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(FqlTable<>))
			{
				var elemType = EnumerableHelper.GetEnumerableItemType(type);
				var tblName = GetTableName(KnownTypeData.GetTypeData(elemType));
				Write("{0}", tblName);
			}
			else
				Build(exp.Value);
		}

		#endregion

		#region Numbers
		private void _Build(int p)
		{
			Write(p.ToString());
		}

		private void _Build(uint p)
		{
			Write(p.ToString());
		}

		private void _Build(long p)
		{
			Write(p.ToString());
		}

		private void _Build(ulong p)
		{
			Write(p.ToString());
		}

		private void _Build(float p)
		{
			Write(p.ToString());
		}

		private void _Build(double p)
		{
			Write(p.ToString());
		}

		private void _Build(byte p)
		{
			Write(p.ToString());
		}

		private void _Build(sbyte p)
		{
			Write(p.ToString());
		}

		private void _Build(short p)
		{
			Write(p.ToString());
		}
		
		private void _Build(ushort p)
		{
			Write(p.ToString());
		}
		#endregion

		#region Utils

		bool HasSelect;
		int InSelect = 0;


		bool IsMethodCall(Expression exp, string methodName)
		{
			return (exp != null && exp.NodeType == ExpressionType.Call && ((MethodCallExpression)exp).Method.Name == methodName);
		}

		void Write(string format, params object[] args)
		{
			sb.AppendFormat(format, args);
			sb.Append(" ");
		}

		private string GetTableName(TypeData td)
		{
			var tblName = td.FqlTableName;
			if (td.Type.Assembly != GetType().Assembly)// && td.Type.Assembly!=typeof(Facebook.Schema.user).Assembly)
				tblName = "app." + tblName;
			return tblName;
		}

		StringBuilder sb;

		#endregion
	}
}
