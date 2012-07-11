using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Linq.Expressions;
using System.IO;

namespace Facebook.Linq
{
	class Error
	{
		internal static Exception ArgumentNull(string p)
		{
			return new ArgumentException("argument is null", p);
		}

		internal static Exception ExpectedQueryableArgument(string p, Type type)
		{
			return new ArgumentException("argument is not of expected type: "+type.FullName, p);
		}
	}

	internal interface IFqlProvider
	{
		TextWriter Log { get; set; }
		Facebook.JsonArray ExecuteFqlQuery(string query);
		//// Methods
		//void ClearConnection();
		//ICompiledQuery Compile(Expression query);
		//void CreateDatabase();
		//bool DatabaseExists();
		//void DeleteDatabase();
		IExecuteResult Execute(Expression query, Type tableRowType);
		//DbCommand GetCommand(Expression query);
		string GetQueryText(Expression query);
		SqlNode GetSqlTree(Expression expression);
		//void Initialize(IDataServices dataServices, object connection);
		//IMultipleResults Translate(DbDataReader reader);
		//IEnumerable Translate(Type elementType, DbDataReader reader);

		//// Properties
		//int CommandTimeout { get; set; }
		//DbConnection Connection { get; }
		//TextWriter Log { get; set; }
		//DbTransaction Transaction { get; set; }	
	}
}
