using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Collections;
using Facebook.Linq;
using Facebook;

namespace Facebook.Linq
{

	class FqlProvider : IFqlProvider
	{
		public FqlProvider(FacebookClient api)
		{
			Api = api;
		}
		FacebookClient Api;

		#region IMyProvider Members

		public System.Data.Linq.IExecuteResult Execute(System.Linq.Expressions.Expression query, Type tableRowType)
		{
			var builder = new FqlQueryBuilder(query);
			var fql = builder.BuildQuery();
			var resultType = query.Type;//
			if (resultType.IsGenericType)
					resultType = resultType.GetGenericArguments()[0];
			if (fql.StartsWith("from "))
				fql = "select * " + fql;
			
			
			//QueryBuilder2
			//var builder = new FqlQueryBuilder(query);
			//var fql = builder.BuildQuery();
			//var select = builder.Select;
			//var resultType = query.Type.GetGenericArguments()[0];
			fql = FqlDataContext.FixQuery(fql);
			var response = ExecuteFqlQuery(fql);
			return new FqlExecuteResult(response, resultType, tableRowType, builder.QueryOptions);
		}

		public string GetQueryText(System.Linq.Expressions.Expression query)
		{
			var builder = new FqlQueryBuilder(query);
			var fql = builder.BuildQuery();
			return fql;
		}

			
		public SqlNode GetSqlTree(Expression query)
		{
			//var builder = new FqlQueryBuilder2(query);
			//return builder.GetSqlExpressionTree();
			throw new Exception();
		}
		#endregion

		#region IFqlProvider Members

		public System.IO.TextWriter Log{get;set;}

		public Facebook.JsonArray ExecuteFqlQuery(string query)
		{
			if (Log != null)
				Log.WriteLine("Executing Fql: " + query);
			var result = (IDictionary<string, object>)Api.Get("fql", new { q = query });
			var data = (IList<object>)result["data"];
			return (Facebook.JsonArray)(data);
		}

		#endregion
	}
}
