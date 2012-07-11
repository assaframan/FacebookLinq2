using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	public class SqlSelect : SqlStatement
	{
		internal SqlExpression From { get; set; }

		internal SqlSelect(SqlExpression selection, SqlExpression from, Expression sourceExpression)
			: base(SqlNodeType.Select, sourceExpression)
		{
			//this.Row = new SqlRow(sourceExpression);
			//this.Selection = selection;
			this.From = from;
			//this.groupBy = new List<SqlExpression>();
			//this.orderBy = new List<SqlOrderExpression>();
			//this.orderingType = SqlOrderingType.Default;
		}
	}
}
