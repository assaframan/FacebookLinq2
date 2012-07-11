using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Linq.Expressions;
using System.ComponentModel;
using Facebook.Linq;

namespace Facebook.Linq
{
	internal interface IFqlDataQuery
	{
		string GetQueryTextWithoutSelect();
		SqlNode GetSqlTree();
	}

	internal sealed class FqlDataQuery<T> : IOrderedQueryable<T>, IQueryable<T>, IQueryProvider, IEnumerable<T>, IOrderedQueryable, IQueryable, IEnumerable, IFqlDataQuery
	{
		// Fields
		//private IBindingList cachedList;
		private FqlDataContext context;
		private Expression queryExpression;
		private Type tableRowType;

		// Methods
		public FqlDataQuery(FqlDataContext context, Expression expression, Type tableRowType)
		{
			this.context = context;
			this.queryExpression = expression;
			this.tableRowType = tableRowType;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return ((IEnumerable<T>)this.context.Provider.Execute(this.queryExpression, tableRowType).ReturnValue).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this.context.Provider.Execute(this.queryExpression, tableRowType).ReturnValue).GetEnumerator();
		}

		IQueryable<S> IQueryProvider.CreateQuery<S>(Expression expression)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			if (!typeof(IQueryable<S>).IsAssignableFrom(expression.Type))
			{
				throw Error.ExpectedQueryableArgument("expression", typeof(IEnumerable<S>));
			}
			return new FqlDataQuery<S>(this.context, expression, typeof(T));
		}

		IQueryable IQueryProvider.CreateQuery(Expression expression)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			Type elementType = EnumerableHelper.GetEnumerableItemType(expression.Type);
			Type type2 = typeof(IQueryable<>).MakeGenericType(new Type[] { elementType });
			if (!type2.IsAssignableFrom(expression.Type))
			{
				throw Error.ExpectedQueryableArgument("expression", type2);
			}
			return (IQueryable)Activator.CreateInstance(typeof(FqlDataQuery<>).MakeGenericType(new Type[] { elementType }), new object[] { this.context, expression });
		}

		object IQueryProvider.Execute(Expression expression)
		{
			return this.context.Provider.Execute(expression, tableRowType).ReturnValue;
		}

		S IQueryProvider.Execute<S>(Expression expression)
		{
			object ret = this.context.Provider.Execute(expression, tableRowType).ReturnValue;
			if (ret != null && typeof(IEnumerable<>).MakeGenericType(typeof(S)).IsAssignableFrom(ret.GetType()))
			{
				//return first enumeration ?
				var en = (IEnumerable)ret;
				var enumerator = en.GetEnumerator();
				if (enumerator.MoveNext())
				{
					return (S)enumerator.Current;
					//One item exists
				}
				else
				{
					if (expression.NodeType == ExpressionType.Call)
					{
						var method = ((System.Linq.Expressions.MethodCallExpression)(expression)).Method;
						if (method.Name == "First")
							throw new Exception("Sequence contains no elements");
						else if (method.Name == "FirstOrDefault")
							return (S)ReflectionHelper.GetDefaultValue(typeof(S));
						else
							throw new NotImplementedException(method.Name);
					}
					throw new NotImplementedException();
				}
			}
			else
				return (S)ret;
		}

		public string GetQueryTextWithoutSelect()
		{
			string s = this.context.Provider.GetQueryText(this.queryExpression);
			if (s.StartsWith("select"))
			{
				s = s.Substring(s.IndexOf("from ") + 5);
			}
			return s;
		}

		public SqlNode GetSqlTree()
		{
			return this.context.Provider.GetSqlTree(this.queryExpression);
		}

		public override string ToString()
		{
			return this.context.Provider.GetQueryText(this.queryExpression);
		}

		Type IQueryable.ElementType
		{
			get
			{
				return typeof(T);
			}
		}

		Expression IQueryable.Expression
		{
			get
			{
				return this.queryExpression;
			}
		}

		IQueryProvider IQueryable.Provider
		{
			get
			{
				return this;
			}
		}
	}
}
