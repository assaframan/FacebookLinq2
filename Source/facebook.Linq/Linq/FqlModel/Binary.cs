using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class SqlBinary : SqlSimpleTypeExpression
	{
		// Fields
		private SqlExpression left;
		private MethodInfo method;
		private SqlExpression right;

		// Methods
		internal SqlBinary(SqlNodeType nt, Type clrType, ProviderType sqlType, SqlExpression left, SqlExpression right)
			: this(nt, clrType, sqlType, left, right, null)
		{
		}

		internal SqlBinary(SqlNodeType nt, Type clrType, ProviderType sqlType, SqlExpression left, SqlExpression right, MethodInfo method)
			: base(nt, clrType, sqlType, right.SourceExpression)
		{
			switch (nt)
			{
				case SqlNodeType.BitAnd:
				case SqlNodeType.BitOr:
				case SqlNodeType.BitXor:
				case SqlNodeType.And:
				case SqlNodeType.Add:
				case SqlNodeType.Coalesce:
				case SqlNodeType.Concat:
				case SqlNodeType.Div:
				case SqlNodeType.EQ:
				case SqlNodeType.EQ2V:
				case SqlNodeType.LE:
				case SqlNodeType.LT:
				case SqlNodeType.GE:
				case SqlNodeType.GT:
				case SqlNodeType.Mod:
				case SqlNodeType.Mul:
				case SqlNodeType.NE:
				case SqlNodeType.NE2V:
				case SqlNodeType.Or:
				case SqlNodeType.Sub:
					this.Left = left;
					this.Right = right;
					this.method = method;
					return;
			}
			throw new Exception("Unexpected node: "+nt);
		}

		// Properties
		internal SqlExpression Left
		{
			get
			{
				return this.left;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentException("value");
				}
				this.left = value;
			}
		}

		internal MethodInfo Method
		{
			get
			{
				return this.method;
			}
		}

		internal SqlExpression Right
		{
			get
			{
				return this.right;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentException("value");
				}
				this.right = value;
			}
		}
	}

	internal static class SqlBinaryExtensions
	{
		public static SqlNodeType Convert(this ExpressionType et)
		{
			switch (et)
			{
				case ExpressionType.Add:
					return SqlNodeType.Add;
				case ExpressionType.AddChecked:
					break;
				case ExpressionType.And:
					return SqlNodeType.And;
				case ExpressionType.AndAlso:
					return SqlNodeType.And;
				case ExpressionType.ArrayIndex:
					break;
				case ExpressionType.ArrayLength:
					break;
				case ExpressionType.Call:
					break;
				case ExpressionType.Coalesce:
					break;
				case ExpressionType.Conditional:
					break;
				case ExpressionType.Constant:
					break;
				case ExpressionType.Convert:
					break;
				case ExpressionType.ConvertChecked:
					break;
				case ExpressionType.Divide:
					break;
				case ExpressionType.Equal:
					return SqlNodeType.EQ;
					//break;
				case ExpressionType.ExclusiveOr:
					break;
				case ExpressionType.GreaterThan:
					break;
				case ExpressionType.GreaterThanOrEqual:
					break;
				case ExpressionType.Invoke:
					break;
				case ExpressionType.Lambda:
					break;
				case ExpressionType.LeftShift:
					break;
				case ExpressionType.LessThan:
					return SqlNodeType.LT;
				case ExpressionType.LessThanOrEqual:
					return SqlNodeType.LE;
				case ExpressionType.ListInit:
					break;
				case ExpressionType.MemberAccess:
					break;
				case ExpressionType.MemberInit:
					break;
				case ExpressionType.Modulo:
					break;
				case ExpressionType.Multiply:
					break;
				case ExpressionType.MultiplyChecked:
					break;
				case ExpressionType.Negate:
					break;
				case ExpressionType.NegateChecked:
					break;
				case ExpressionType.New:
					break;
				case ExpressionType.NewArrayBounds:
					break;
				case ExpressionType.NewArrayInit:
					break;
				case ExpressionType.Not:
					break;
				case ExpressionType.NotEqual:
					break;
				case ExpressionType.Or:
					return SqlNodeType.Or;
				case ExpressionType.OrElse:
					break;
				case ExpressionType.Parameter:
					break;
				case ExpressionType.Power:
					break;
				case ExpressionType.Quote:
					break;
				case ExpressionType.RightShift:
					break;
				case ExpressionType.Subtract:
					break;
				case ExpressionType.SubtractChecked:
					break;
				case ExpressionType.TypeAs:
					break;
				case ExpressionType.TypeIs:
					break;
				case ExpressionType.UnaryPlus:
					break;
				default:
					break;
			}
			throw new Exception();
		}
	}
}
