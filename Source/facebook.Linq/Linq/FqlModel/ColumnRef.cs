using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class SqlColumnRef : SqlNode
	{
		internal string ColumnName;
		internal SqlColumnRef(Expression exp, string columnName) : base(SqlNodeType.ColumnRef, exp)
		{
			ColumnName = columnName;
		}
	}
}
