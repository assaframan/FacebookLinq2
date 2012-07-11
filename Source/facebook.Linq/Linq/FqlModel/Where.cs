using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class Where : SqlExpression
	{
		internal SqlExpression Source;
		internal SqlExpression Condition;
		internal Where(SqlNodeType nodeType, Expression sourceExpression, SqlExpression source, SqlExpression condition)
			: base(nodeType, source.ClrType, sourceExpression)
		{
			Source = source;
			Condition = condition;
		}

		internal override ProviderType SqlType
		{
			get { throw new NotImplementedException(); }
		}
	}
}
