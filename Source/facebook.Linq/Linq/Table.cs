using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;


namespace Facebook.Linq
{
	interface IFqlTable
	{
	}
	public class FqlTable<T> : IQueryable, IQueryable<T>, IQueryProvider, IFqlTable
	{
		public FqlTable(FqlDataContext db)
		{
			this.context = db;
		}
		#region IEnumerable<T> Members

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IQueryable Members

		public Type ElementType
		{
			get { return typeof(T); }
		}

		public Expression Expression
		{
			get { return Expression.Constant(this); }
		}

		public IQueryProvider Provider
		{
			get { return this; }
		}

		#endregion

		#region IQueryProvider Members

		public IQueryable<TResult> CreateQuery<TResult>(Expression expression)
		{
			if (expression == null)
			{
				throw new ArgumentException("expression");
			}
			if (!typeof(IQueryable<TResult>).IsAssignableFrom(expression.Type))
			{
				throw new ArgumentException("expected type: "+typeof(IEnumerable<TResult>).FullName,"expression");
			}
			return new FqlDataQuery<TResult>(this.context, expression, typeof(T));
		}

		FqlDataContext context;

		public IQueryable CreateQuery(Expression expression)
		{
			throw new NotImplementedException();
		}

		public TResult Execute<TResult>(Expression expression)
		{
			throw new NotImplementedException();
		}

		public object Execute(Expression expression)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
