using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class SqlTable : SqlNode
	{
		internal string TableName;
		internal SqlTable(Expression sourceExpression, string tableName)
			: base(SqlNodeType.Table, sourceExpression)
		{
			TableName = tableName;
		}
	}
}
