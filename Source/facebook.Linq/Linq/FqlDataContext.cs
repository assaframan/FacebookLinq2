using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;
using System.Collections;
using Facebook;
using System.IO;

namespace Facebook.Linq
{
	/// <summary>
	/// Represents a facebook/application database, as provided by the Facebook FQL API
	/// </summary>
	public abstract class FqlDataContext : IDisposable
	{
		protected FqlDataContext(FacebookClient api)
		{
			Provider = new FqlProvider(api);
			Api = api;
			ReuseExistingInstances = true;
		}

		public FacebookClient Api { get; private set; }
		internal IFqlProvider Provider;

		protected FqlTable<T> GetTable<T>()
		{
			return new FqlTable<T>(this);
		}

		#region Object Cache (re-uses instances that can be identified, such as user and photos, but not group memberships)

		/// <summary>
		/// When on, objects that are received from facebook and have an identity field will re-use the same instance to make databinding easier
		/// </summary>
		public bool ReuseExistingInstances { get; set; }

		/// <summary>
		/// Gets an object from the database cache given its key. When needed, it also queries facebook for the requested object.
		/// </summary>
		public virtual T GetObject<T>(object key, bool loadIfNeeded) where T : class // : FacebookObject
		{
			if (!ReuseExistingInstances || key == null)
				return null;
			var typ = typeof(T);
			if (ObjectCache.ContainsKey(typ))
			{
				if (ObjectCache[typ].ContainsKey(key))
					return ObjectCache[typ][key] as T;
			}
			if (loadIfNeeded)
			{
				T item = LoadObject<T>(key);
				if (item != null)
					StoreObject<T>(item, key);
				return item;
			}

			return null;
		}

		/// <summary>
		/// Stores an object in the database cache.
		/// </summary>
		public virtual void StoreObject<T>(T o, object key) where T : class// : FacebookObject
		{
			StoreObject(KnownTypeData.GetTypeData(typeof(T)),o, key);
		}

		internal virtual void StoreObject(TypeData td, object o, object key)
		{
			if (!ReuseExistingInstances || key == null)
				return;
			var typ = td.Type;
			if (!ObjectCache.ContainsKey(typ))
				ObjectCache.Add(typ, new Dictionary<object, object>());
			if (!ObjectCache[typ].ContainsKey(key))
				ObjectCache[typ].Add(key, o);
		}

		//Type / Key / Value
		Dictionary<Type, Dictionary<object, object>> ObjectCache = new Dictionary<Type, Dictionary<object, object>>();

		/// <summary>
		/// Performs a generic FQL query against facebook
		/// </summary>
		public IEnumerable<T> PerformGenericFql<T>(string fql) where T : class
		{
			var items = new List<T>();
			fql = FixQuery(fql);

			var result = Provider.ExecuteFqlQuery(fql);
			var reader = new FacebookDataReader(result);
			var td = KnownTypeData.GetTypeData(typeof(T));
			while (reader.Read())
      {
				T item = null;
				var elem = Activator.CreateInstance<T>();
				var fetched = false;
				if (td.IdentityProperty != null)
				{
					var idVal = reader[td.IdentityProperty.FqlFieldName];
					item = GetObject<T>(idVal,false);
					fetched = item != null;
				}
				if (!fetched)
				{
					item = Activator.CreateInstance<T>();
					//item.DataContext = this;
					if (item != null && td.IdentityProperty != null)
					{
						StoreObject<T>(item, reader[td.IdentityProperty.FqlFieldName]);
					}
				}

				foreach (var pData in td.Properties)
				{
					pData.Value.PropertyInfo.SetValue(item, reader[pData.Value.FqlFieldName], null);
				}
				items.Add(item);
			}
			return items;
		}

		internal static string FixQuery(string fql)
		{
			var words = fql.Split(' ');
			if (words.Length < 3)
				return fql;
			if (words[0].ToLower() != "select")
				return fql;
			if (words[2].ToLower() != "from")
				return fql;
			var replacement = words[1];
			if (replacement != "*")
				return fql;			
			var tableName = words[3].ToLower();
			if (tableName.StartsWith("app."))
				tableName = tableName.Substring(4);
			var td = KnownTypeData.GetTypeDataByTableName(tableName);
			if (td == null)
				throw new Exception();
			replacement = td.PropertiesByFieldName.Keys.StringConcat(",");
			if (replacement.IsNotNullOrEmpty())
				words[1] = replacement;
			return words.StringConcat(" ");
		}

		#region Overrides for LinqExtender

		public IDataReader ExecuteReader(CommandType cmdType, string sql)
		{
			var xml = this.Provider.ExecuteFqlQuery(sql);
			return new FacebookDataReader(xml);
		}
		
		#endregion

		private T LoadObject<T>(object key) where T : class //FacebookObject
		{
			var td = KnownTypeData.GetTypeData(typeof(T));
			var column = td.IdentityProperty;
			if (column==null)
				return null;
			var propsCSV = td.Properties.StringConcat(p=>p.Value.FqlFieldName,"",",","");
			var fql = String.Format("SELECT {0} from {1} where {2}={3} limit 1",
				propsCSV,
				td.FqlTableName,
				td.IdentityProperty.FqlFieldName,
				key);
			return (GetType().GetMethod("PerformGenericFql").MakeGenericMethod(typeof(T)).Invoke(this, new object[] { fql }) as IEnumerable<T>).FirstOrDefault();
		}

		#endregion


		public virtual void Dispose()
		{
			ObjectCache = null;
		}

		public TextWriter Log
		{
			get
			{
				return Provider.Log;
			}
			set
			{
				Provider.Log = value;
			}
		}
	}


	///// <summary>
	///// Represents an application database, as provided by the Facebook API
	///// </summary>
	//abstract class FqlApplicationDataContext : FqlDataContext
	//{
	//  protected FqlApplicationDataContext(API api)
	//    : base(api)
	//  {
	//    //KnownTypeData.GetTypeData
	//  }

	//  public void InsertOnSubmit<T>(T t) where T : class
	//  {
	//    if (!PendingObjects.ContainsKey(typeof(T)))
	//      PendingObjects.Add(typeof(T), new HashSet<object>());
	//    PendingObjects[typeof(T)].Add(t);
	//  }

	//  public void InsertAllOnSubmit<T>(IEnumerable<T> items) where T : class
	//  {
	//    if (!PendingObjects.ContainsKey(typeof(T)))
	//      PendingObjects.Add(typeof(T), new HashSet<object>());
	//    var l = PendingObjects[typeof(T)];
	//    foreach(var item in items)
	//      l.Add(item);
	//  }

	//  private Dictionary<string, string> BuildObjectDictionary(TypeData td, object o)
	//  {
	//    var ret = new Dictionary<string, string>();
	//    foreach (var p in td.Properties)
	//    {
	//      var fn = p.Value.FqlFieldName;
	//      var val = p.Value.PropertyInfo.GetValue(o, null); //TODO: Convert to either string or long or null				
	//      if (val == null)
	//        continue;
	//      if (!(val is string))
	//      {
	//        var l = ConvertToFacebookNumber(val);;
	//        if (l == 0)
	//          continue;
	//        else
	//          val = l;

	//      }
	//      ret.Add(fn, val.ToString());
	//    }
	//    return ret;
	//  }

	//  private long ConvertToFacebookNumber(object val)
	//  {
	//    //enums are not supported
	//    var vt = val.GetType();
	//    if (vt.IsEnum)
	//    {
	//      throw new Exception("Enums are not supported yet");
	//    }
	//    if (vt == typeof(long))
	//    {
	//      return (long)val;
	//    }
	//    if (vt == typeof(DateTime))
	//    {
	//      DateTime? dt = (DateTime)val;
	//      return Convert.ToInt64(DateHelper.ConvertDateToDouble(dt));
	//    }
	//    if (vt == typeof(DateTime?))
	//    {
	//      DateTime? dt = (DateTime?)val;
	//      val = DateHelper.ConvertDateToDouble(dt);
	//      return (long)val;
	//    }
	//    if (vt == typeof(bool))
	//    {
	//      bool b = (bool)val;
	//      return b ? 1 : 0;
	//    }
	//    throw new NotImplementedException();
	//  }

	//  public void SubmitChanges()
	//  {
	//    foreach (var typ in PendingObjects.Keys)
	//    {
	//      var td = KnownTypeData.GetTypeData(typ);
	//      foreach (var o in PendingObjects[typ])
	//      {
	//        var dict = BuildObjectDictionary(td, o);
	//        var newId = Api.data.createObject(td.FqlTableName, dict);
	//        if (td.IdentityProperty != null && td.IdentityProperty.FqlFieldName=="_id")
	//          td.IdentityProperty.PropertyInfo.SetValue(o, newId, null);
	//        StoreObject(td, o, newId);
	//      }
	//      PendingObjects[typ].Clear();
	//    }
	//  }

	//  private Dictionary<Type, HashSet<object>> PendingObjects = new Dictionary<Type, HashSet<object>>();  



	//  #region Model Maintenance
	//  private IEnumerable<PropertyInfo> TableProperties
	//  {
	//    get
	//    {
	//      return GetType().GetProperties().Where(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(FqlTable<>));
	//    }
	//  }
		
	//  public void BuildModel()
	//  {
	//    BuildModel(false);
	//  }

	//  public void BuildModel(bool dropOldModel)
	//  {
	//    foreach (var tbl in TableProperties)
	//    {
	//      var itemType = tbl.PropertyType.GetGenericArguments()[0];
	//      var td = KnownTypeData.GetTypeData(itemType);
	//      var tblName = td.FqlTableName;

	//      if (dropOldModel)
	//      {
	//        try
	//        {
	//          Api.data.dropObjectType(tblName);
	//        }
	//        catch
	//        {
	//          //Drop failed, what can you do..
	//        }
	//      }

	//      Api.data.createObjectType(tblName);

	//      foreach (var pi in td.Properties)
	//      {
	//        var propName = pi.Key;
	//        var pd = pi.Value;

	//        //if (dropOldModel && pd.FqlFieldName!="_id")
	//        //{
	//        //  try
	//        //  {
	//        //    Api.data.undefineObjectProperty(tblName, pd.FqlFieldName);
	//        //  }
	//        //  catch
	//        //  {
	//        //    //Drop failed, what can one do..
	//        //  }
	//        //}

	//        var fbPropertyType = GetFacebookDataTypeId(pd.PropertyInfo.PropertyType);
	//        if (fbPropertyType == 0)
	//          throw new Exception("Invalid property type: " + pd.PropertyInfo.PropertyType + " for property " + tbl.Name + "." + pd.PropertyInfo.Name);

	//        if (pd.FqlFieldName == "_id")
	//          continue;
	//        Api.data.defineObjectProperty(tblName, pd.FqlFieldName, fbPropertyType);
	//      }
	//    }
	//  }

	//  public void DeleteModel()
	//  {
	//    foreach (var tbl in TableProperties)
	//    {
	//      var itemType = tbl.PropertyType.GetGenericArguments()[0];
	//      var td = KnownTypeData.GetTypeData(itemType);
	//      var tblName = td.FqlTableName;

	//      try
	//      {
	//        Api.data.dropObjectType(tblName);
	//      }
	//      catch
	//      {
	//        //Drop failed
	//      }
	//    }
	//  }

	//  public void VerifyModel()
	//  {
	//    throw new NotImplementedException();
	//  }

	//  private int GetFacebookDataTypeId(Type t)
	//  {
	//    int fbPropertyType = 0;
	//    //1 - long or nullable long
	//    //2 - short string
	//    //3 - long string
	//    if (t == typeof(long))
	//      fbPropertyType = 1;
	//    else if (t == typeof(long?))
	//      fbPropertyType = 1;
	//    else if (t == typeof(bool))
	//      fbPropertyType = 1;
	//    else if (t == typeof(DateTime))
	//      fbPropertyType = 1;
	//    else if (t == typeof(DateTime?))
	//      fbPropertyType = 1;
	//    else if (t == typeof(string))
	//      fbPropertyType = 3;
	//    else if (t.IsEnum)
	//      fbPropertyType = 0;			
	//    return fbPropertyType;

	//  }

	//  public bool ModelExists
	//  {
	//    get
	//    {
	//      foreach (var tbl in TableProperties)
	//      {
	//        var itemType = tbl.PropertyType.GetGenericArguments()[0];
	//        var td = KnownTypeData.GetTypeData(itemType);
	//        var tblName = td.FqlTableName;

	//        var fbtd = Api.data.getObjectType(tblName);

	//        foreach (var pi in td.Properties)
	//        {
	//          var propName = pi.Key;
	//          var pd = pi.Value;
	//          var fbPropertyType = GetFacebookDataTypeId(pd.PropertyInfo.PropertyType);
	//          if (fbPropertyType==0)
	//            throw new Exception("Invalid property type: " + pd.PropertyInfo.PropertyType + " for property " + tbl.Name + "." + pd.PropertyInfo.Name);
	//          if (pd.FqlFieldName == "_id")
	//            continue;
	//          if (fbtd.FirstOrDefault(t => t.data_type == fbPropertyType && t.name == pd.FqlFieldName) == null)
	//            return false;
	//        }
	//      }
	//      return true;
	//    }
	//  }

	//  #endregion
	//}
}

