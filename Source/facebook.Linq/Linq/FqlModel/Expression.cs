using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal abstract class SqlExpression : SqlNode
	{
		// Fields
		private Type clrType;

		// Methods
		internal SqlExpression(SqlNodeType nodeType, Type clrType, Expression sourceExpression)
			: base(nodeType, sourceExpression)
		{
			this.clrType = clrType;
		}

		internal void SetClrType(Type type)
		{
			this.clrType = type;
		}

		// Properties
		internal Type ClrType
		{
			get
			{
				return this.clrType;
			}
		}

		internal bool IsConstantColumn
		{
			get
			{
				//if (base.NodeType == SqlNodeType.Column)
				//{
				//  SqlColumn column = (SqlColumn)this;
				//  if (column.Expression != null)
				//  {
				//    return column.Expression.IsConstantColumn;
				//  }
				//}
				//else
				//{
				//  if (base.NodeType == SqlNodeType.ColumnRef)
				//  {
				//    return ((SqlColumnRef)this).Column.IsConstantColumn;
				//  }
				//  if (base.NodeType == SqlNodeType.OptionalValue)
				//  {
				//    return ((SqlOptionalValue)this).Value.IsConstantColumn;
				//  }
				//  if ((base.NodeType == SqlNodeType.Value) || (base.NodeType == SqlNodeType.Parameter))
				//  {
				//    return true;
				//  }
				//}
				//return false;
				return false;
			}
		}

		internal abstract ProviderType SqlType { get; }
	}

 

}
