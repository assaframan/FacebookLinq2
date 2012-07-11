using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class SqlContains : SqlExpression
	{
		internal SqlExpression Source;
		internal SqlExpression Element;

		public SqlContains(SqlNodeType nodeType, Expression sourceExpression, SqlExpression source, SqlExpression element)
			: base(nodeType, typeof(bool), sourceExpression)
		{
			this.Source = source;
			this.Element = element;
		}

		internal override ProviderType SqlType
		{
			get { throw new NotImplementedException(); }
		}
	}
}
