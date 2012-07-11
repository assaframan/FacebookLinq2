using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class SqlTake : SqlNode
	{
		internal SqlExpression Amount;
		internal SqlExpression From;

		internal SqlTake(SqlNodeType nt, Expression sourceExpression, SqlExpression from, SqlExpression amount)
			: base(nt, sourceExpression)
		{
			Amount = amount;
			From = from;
		}
	}

	internal class SqlSkip : SqlNode
	{
		internal SqlExpression Amount;
		internal SqlExpression From;

		internal SqlSkip(SqlNodeType nt, Expression sourceExpression, SqlExpression from, SqlExpression amount)
			: base(nt, sourceExpression)
		{
			Amount = amount;
			From = from;
		}
	}
}
