using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class SqlNew : SqlExpression
	{
		public SqlNew(Expression exp)
			: base
				(SqlNodeType.New, null, exp)
		{
		}

		internal override ProviderType SqlType
		{
			get { throw new NotImplementedException(); }
		}
	}
}
