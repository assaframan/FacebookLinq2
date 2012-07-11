using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal abstract class SqlSimpleTypeExpression : SqlExpression
	{
		// Fields
		private ProviderType sqlType;

		// Methods
		internal SqlSimpleTypeExpression(SqlNodeType nodeType, Type clrType, ProviderType sqlType, Expression sourceExpression)
			: base(nodeType, clrType, sourceExpression)
		{
			this.sqlType = sqlType;
		}

		internal void SetSqlType(ProviderType type)
		{
			this.sqlType = type;
		}

		// Properties
		internal override ProviderType SqlType
		{
			get
			{
				return this.sqlType;
			}
		}
	}
}
