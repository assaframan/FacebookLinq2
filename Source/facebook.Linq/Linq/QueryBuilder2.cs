//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Linq.Expressions;
//using Facebook.Linq;
//using ConsoleApplication1.FqlToLinq;
//using CodeRun.Util;
//using System.Reflection;
//
//using ConsoleApplication1;

//namespace Facebook.Linq.LinqToFql
//{
//  public class FqlQueryBuilder2
//  {
//    public FqlQueryBuilder2(Expression query)
//    {
//      Query = query;
//    }
//    public Expression Query;

//    public string BuildQuery()
//    {
//      SqlNode node = GetSqlExpressionTree();
//      return "";
//    }

//    public SqlNode GetSqlExpressionTree()
//    {
//      return Build(Query);
//    }












//    bool HasSelect;

//    SqlNode Build(string literal, Expression exp)
//    {
//      return new SqlValue(typeof(string), null, literal, true, exp);
//    }

//    //SqlNode Build(IEnumerable<Expression> exps)
//    //{
//    //  foreach (var exp in exps)
//    //  {
//    //    Build(exp);
//    //  }
//    //}

//    int InSelect = 0;
//    private SqlNode _Build(MethodCallExpression exp)
//    {
//      switch (exp.Method.Name)
//      {
//        case "Where":
//          return BuildWhere(exp);
//        case "Select":
//          return BuildSelect(exp);
//        case "Contains":
//          return BuildContains(exp);
//        case "Take":
//          return BuildTake(exp);
//        case "Skip":
//          return BuildSkip(exp);
//        default:
//          throw new Exception();
//      }				
//    }

//    private SqlSkip BuildSkip(MethodCallExpression exp)
//    {
//      var source = Build(exp.Arguments[0]) as SqlExpression;
//      var amount = Build(exp.Arguments[1]) as SqlExpression;
//      return new SqlSkip(SqlNodeType.Skip, exp, source, amount);
//    }

//    private SqlTake BuildTake(MethodCallExpression exp)
//    {
//      var source = Build(exp.Arguments[0]) as SqlExpression;
//      var amount = Build(exp.Arguments[1]) as SqlExpression;
//      return new SqlTake(SqlNodeType.Take, exp, source, amount);
//    }

//    private SqlNode BuildContains(MethodCallExpression exp)
//    {
//      var source = Build(exp.Arguments[0]) as SqlExpression;
//      var element = Build(exp.Arguments[1]) as SqlExpression;
//      return new SqlContains(SqlNodeType.In, exp, source, element);
//    }

//    private SqlSelect BuildSelect(MethodCallExpression exp)
//    {
//      InSelect++;
//      if (!HasSelect)
//      {
//        HasSelect = true;
//        Select = ((UnaryExpression)exp.Arguments[1]).Operand;
//      }
//      var selection = Build(exp.Arguments[1]) as SqlExpression;
//      var from = Build(exp.Arguments[0]) as SqlExpression;
//      InSelect--;
//      return new SqlSelect(selection, from, exp);
//    }

//    private SqlNode BuildWhere(MethodCallExpression exp)
//    {
//      var source = Build(exp.Arguments[1]) as SqlExpression;
//      var condition = Build(exp.Arguments[0]) as SqlExpression;
//      return new Where(SqlNodeType.Where, exp, source, condition);
//    }

//    #region switch

//    private SqlNode Build(Expression exp)
//    {
//      switch (exp.NodeType)
//      {
//        case ExpressionType.Call:
//          return _Build((MethodCallExpression)exp);
//        case ExpressionType.Constant:
//          return _Build((ConstantExpression)exp);
//        case ExpressionType.Quote:
//          return _Build((UnaryExpression)exp);
//        case ExpressionType.Lambda:
//          return _Build((LambdaExpression)exp);
//        case ExpressionType.Equal:
//          return _Build((BinaryExpression)exp);
//        case ExpressionType.MemberAccess:
//          return _Build((MemberExpression)exp);
//        case ExpressionType.Add:
//          return _Build((BinaryExpression)exp);
//        case ExpressionType.New:
//          return _Build((NewExpression)exp);

//        case ExpressionType.AddChecked:
//        case ExpressionType.And:
//        case ExpressionType.AndAlso:
//        case ExpressionType.ArrayIndex:
//        case ExpressionType.ArrayLength:
//        case ExpressionType.Coalesce:
//        case ExpressionType.Conditional:
//        case ExpressionType.Convert:
//        case ExpressionType.ConvertChecked:
//        case ExpressionType.Divide:
//        case ExpressionType.ExclusiveOr:
//        case ExpressionType.GreaterThan:
//        case ExpressionType.GreaterThanOrEqual:
//        case ExpressionType.Invoke:
//        case ExpressionType.LeftShift:
//        case ExpressionType.LessThan:
//        case ExpressionType.LessThanOrEqual:
//        case ExpressionType.ListInit:
//        case ExpressionType.MemberInit:
//        case ExpressionType.Modulo:
//        case ExpressionType.Multiply:
//        case ExpressionType.MultiplyChecked:
//        case ExpressionType.Negate:
//        case ExpressionType.NegateChecked:
//        case ExpressionType.NewArrayBounds:
//        case ExpressionType.NewArrayInit:
//        case ExpressionType.Not:
//        case ExpressionType.NotEqual:
//        case ExpressionType.Or:
//        case ExpressionType.OrElse:
//        case ExpressionType.Parameter:
//        case ExpressionType.Power:
//        case ExpressionType.RightShift:
//        case ExpressionType.Subtract:
//        case ExpressionType.SubtractChecked:
//        case ExpressionType.TypeAs:
//        case ExpressionType.TypeIs:
//        case ExpressionType.UnaryPlus:
//        default:
//          throw new NotImplementedException(exp.NodeType + " is not supported");
//      }
//    }
//    #endregion

//    private SqlNode _Build(NewExpression exp)
//    {
//      throw new NotImplementedException();

//      //bool first = true;
//      //foreach (var arg in exp.Arguments)
//      //{
//      //  if (first)
//      //    first = false;
//      //  else
//      //    Write(",");
//      //  Build(arg);
//      //}
//    }

//    private SqlNode _Build(MemberExpression exp)
//    {
//      var member = exp.Member;
//      var memberType = ReflectionHelper.GetMemberType(member);
//      if (typeof(IFqlDataQuery).IsAssignableFrom(memberType)) //Query
//      {
//        if (exp.Expression is ConstantExpression)
//        {
//          var obj = ((ConstantExpression)(exp.Expression)).Value;
//          var value = ReflectionHelper.GetMemberValue(member, obj);
//          //new FqlQueryBuilder2(value)
//          Build(value);
//        }
//        else
//          throw new NotSupportedException();
//      }
//      else if (typeof(IFqlTable).IsAssignableFrom(memberType)) //Table
//      {
//        var tableRowType = ((PropertyInfo)exp.Member).PropertyType.GetGenericArguments()[0];
//        var td = KnownTypeData.GetTypeData(tableRowType);
//        return new SqlTable(exp, td.FqlTableName);
//      }
//      else //Column
//      {
//        var memberName = exp.Member.Name;
//        var td = KnownTypeData.GetTypeData(exp.Member.DeclaringType);
//        if (td.Properties.ContainsKey(memberName))
//        {
//          var pd = td.Properties[exp.Member.Name];
//          return new SqlColumnRef(exp, pd.FqlFieldName);
//        }
//        else //Variable
//        {
//          if (exp.Expression is ConstantExpression)
//          {
//            var obj = ((ConstantExpression)(exp.Expression)).Value;
//            var value = ReflectionHelper.GetMemberValue(member, obj);
//            return new SqlValue(value.GetType(), null, value, false, exp);
//          }
//          else
//            throw new NotSupportedException();
//        }
//      }
//      throw new NotSupportedException();
//    }

//    private SqlNode _Build(BinaryExpression exp)
//    {
//      var left = Build(exp.Left) as SqlExpression;
//      var right = Build(exp.Right) as SqlExpression;
//      return new SqlBinary(exp.NodeType.Convert(), null, null, left, right);
//    }

//    private SqlNode _Build(LambdaExpression exp)
//    {
//      return Build(exp.Body);
//    }

//    private SqlNode _Build(UnaryExpression exp)
//    {
//      return Build(exp.Operand);
//    }

//    private SqlNode _Build(ConstantExpression exp)
//    {
//      var value = exp.Value;
//      var type = value.GetType();
//      if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(FqlTable<>))
//      {
//        var elemType = TypeSystem.GetElementType(type);
//        return new SqlTable(exp, KnownTypeData.GetTypeData(elemType).FqlTableName);
//      }
//      else
//        return Build(exp.Value);
//    }

//    private SqlNode Build(object value)
//    {
//      if (value is Expression)
//        return Build((Expression)value);
//      else if (value is string)
//        return Build((string)value);
//      else if (value is int)
//        return _Build((int)value);
//      else if (value is long)
//        return _Build((long)value);
//      else if (value is IFqlDataQuery)
//      {
//        var innerQuery = (IFqlDataQuery)value;
//        return innerQuery.GetSqlTree();
//        /*var innerQueryText = innerQuery.ToString();
//        if (InSelect > 0 && innerQueryText.StartsWith("from"))
//        {
//          Write(innerQueryText.Substring(4));
//        }
//        else
//        {
//          Write("(");
//          Write(innerQueryText);//
//          Write(")");
//        }*/
//      }
//      else
//        throw new NotImplementedException("");
//    }

//    #region Numbers
//    private SqlNode _Build(int p)
//    {
//      return new SqlValue(typeof(int), null, p, false, null);
//    }

//    private SqlNode _Build(uint p)
//    {
//      return new SqlValue(typeof(uint), null, p, false, null);
//    }

//    private SqlNode _Build(long p)
//    {
//      return new SqlValue(typeof(long), null, p, false, null);
//    }

//    private SqlNode _Build(ulong p)
//    {
//      return new SqlValue(typeof(ulong), null, p, false, null);
//    }

//    private SqlNode _Build(float p)
//    {
//      return new SqlValue(typeof(float), null, p, false, null);
//    }

//    private SqlNode _Build(double p)
//    {
//      return new SqlValue(typeof(double), null, p, false, null);
//    }

//    private SqlNode _Build(byte p)
//    {
//      return new SqlValue(typeof(byte), null, p, false, null);
//    }

//    private SqlNode _Build(sbyte p)
//    {
//      return new SqlValue(typeof(sbyte), null, p, false, null);
//    }

//    private SqlNode _Build(short p)
//    {
//      return new SqlValue(typeof(short), null, p, false, null);
//    }

//    private SqlNode _Build(ushort p)
//    {
//      return new SqlValue(typeof(ushort), null, p, false, null);
//    }
//    #endregion

//    public Expression Select { get; set; }


//  }
//}
