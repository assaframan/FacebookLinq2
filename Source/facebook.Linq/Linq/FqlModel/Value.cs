using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal class SqlValue : SqlSimpleTypeExpression
	{
		// Fields
		private bool isClient;
		private object value;

		// Methods
		internal SqlValue(Type clrType, ProviderType sqlType, object value, bool isClientSpecified, Expression sourceExpression)
			: base(SqlNodeType.Value, clrType, sqlType, sourceExpression)
		{
			this.value = value;
			this.isClient = isClientSpecified;
		}

		// Properties
		internal bool IsClientSpecified
		{
			get
			{
				return this.isClient;
			}
		}

		internal object Value
		{
			get
			{
				return this.value;
			}
		}

	}
}
