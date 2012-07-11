using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Facebook.Linq
{
	internal enum SqlNodeType
	{
		Add,
		Alias,
		AliasRef,
		And,
		Assign,
		Avg,
		Between,
		BitAnd,
		BitNot,
		BitOr,
		BitXor,
		Block,
		Cast,
		ClientArray,
		ClientCase,
		ClientParameter,
		ClientQuery,
		ClrLength,
		Coalesce,
		Column,
		ColumnRef,
		Concat,
		Convert,
		Count,
		Covar,
		Delete,
		DiscriminatedType,
		DiscriminatorOf,
		Div,
		DoNotVisit,
		Element,
		ExprSet,
		EQ,
		EQ2V,
		Exists,
		FunctionCall,
		In,
		IncludeScope,
		IsNotNull,
		IsNull,
		LE,
		Lift,
		Link,
		Like,
		LongCount,
		LT,
		GE,
		Grouping,
		GT,
		Insert,
		Join,
		JoinedCollection,
		Max,
		MethodCall,
		Member,
		MemberAssign,
		Min,
		Mod,
		Mul,
		Multiset,
		NE,
		NE2V,
		Negate,
		New,
		Not,
		Not2V,
		Nop,
		ObjectType,
		Or,
		OptionalValue,
		OuterJoinedValue,
		Parameter,
		Property,
		Row,
		RowNumber,
		ScalarSubSelect,
		SearchedCase,
		Select,
		SharedExpression,
		SharedExpressionRef,
		SimpleCase,
		SimpleExpression,
		Stddev,
		StoredProcedureCall,
		Sub,
		Sum,
		Table,
		TableValuedFunctionCall,
		Treat,
		TypeCase,
		Union,
		Update,
		UserColumn,
		UserQuery,
		UserRow,
		Variable,
		Value,
		ValueOf,










		Take,
		Skip,

		Where,
		Binary
	}

	public class SqlNode
	{
		// Fields
    private SqlNodeType nodeType;
    private Expression sourceExpression;

    // Methods
		internal SqlNode(SqlNodeType nodeType, Expression sourceExpression)
		{
			this.nodeType = nodeType;
			this.sourceExpression = sourceExpression;
		}

    internal void ClearSourceExpression()
		{
			this.sourceExpression = null;
		}

    // Properties
		internal SqlNodeType NodeType
		{
			get
			{
				return this.nodeType;
			}
		}

		internal Expression SourceExpression
		{
			get
			{
				return this.sourceExpression;
			}
		}
	}
}
