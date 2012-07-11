using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Data.Linq.Mapping;
using Microsoft.Xml.Schema.Linq;


namespace Facebook.Linq
{
	/// <summary>
	/// Property metadata descriptor
	/// </summary>
	public class PropertyData
	{
		internal PropertyData()
		{
		}
		internal PropertyData(PropertyInfo pi)
		{
			this.PropertyInfo = pi;
			ColumnAttribute = ReflectionHelper.GetAttributes<ColumnAttribute>(pi, true).FirstOrDefault();
			FqlFieldName = GetLinqFieldName();
			IsLinqIdentity = GetIsLinqIdentity();
		}

		ColumnAttribute ColumnAttribute;

		internal PropertyInfo PropertyInfo;
		internal string FqlFieldName;
		internal bool IsLinqIdentity;


		internal bool GetIsLinqIdentity()
		{
			if (ColumnAttribute != null)
				return ColumnAttribute.IsPrimaryKey;
			return false; //TODO:
		}

		internal string GetLinqFieldName()
		{
			if (ColumnAttribute != null)
				return ColumnAttribute.Name;
			return PropertyInfo.Name.ToFqlIdentifier();
		}
	}

	/// <summary>
	/// Type metadata descriptor cache
	/// </summary>
	internal class KnownTypeData
	{
		static object GetTypeDataEntrance = new object();
		internal static TypeData GetTypeData(Type t)
		{
			if (Types.ContainsKey(t))
				return Types[t];
			lock (GetTypeDataEntrance)
			{
				if (Types.ContainsKey(t))
					return Types[t];
				var td = new TypeData(t);
				Types.Add(t, td);
				if(td.FqlTableName!=null)
					TypesByTableName.Add(td.FqlTableName, td);
				return td;
			}
		}


		internal static TypeData GetTypeDataByTableName(string tableName)
		{
			return TypesByTableName.TryGetValue(tableName);
		}

		static Dictionary<string, TypeData> TypesByTableName = new Dictionary<string, TypeData>();
		static Dictionary<Type, TypeData> Types = new Dictionary<Type, TypeData>();
	}

	/// <summary>
	/// Type metadata descriptor
	/// </summary>
	internal class TypeData
	{
		internal TypeData()
		{
		}

		internal TypeData(Type t)
		{
			this.Type = t;
			FqlTableName = t.GetLinqTableName();
			if (FqlTableName != null)
			{
				foreach (var p in t.GetProperties())
				{
					if (p.IsFqlColumn())
					{
						var pd = new PropertyData(p);
						Properties.Add(p.Name, pd);
						PropertiesByFieldName.Add(pd.FqlFieldName, pd);
						if (pd.IsLinqIdentity)
						{
							if (IdentityProperty == null)
								IdentityProperty = pd;
							else
								throw new Exception("Type " + t.FullName + " has more than one identity property specified");
						}
					}

				}
			}
		}

		internal Type Type;
		internal string FqlTableName;
		internal Dictionary<string, PropertyData> Properties = new Dictionary<string, PropertyData>();
		internal Dictionary<string, PropertyData> PropertiesByFieldName = new Dictionary<string, PropertyData>();

		internal PropertyData GetPropertyByFieldName(string propertyName)
		{
			if (PropertiesByFieldName.ContainsKey(propertyName))
				return PropertiesByFieldName[propertyName];
			return null;
		}
		internal PropertyData IdentityProperty;
	}

	internal static class Helper
	{
		internal static bool IsFqlColumn(this PropertyInfo pi)
		{
			if (pi.DeclaringType.IsSubclassOf(typeof(XTypedElement)) && pi.GetSetMethod()!=null && IsSupported(pi.PropertyType))
				return true;
			return pi.GetCustomAttributes(typeof(ColumnAttribute), true).Length > 0;
		}

		static HashSet<Type> SupportedTypes = new HashSet<Type> { typeof(Int64), typeof(Decimal), typeof(string), typeof(bool), typeof(DateTime) };
		private static bool IsSupported(Type type)
		{
			if (type.IsEnum)
				return true;
			if (SupportedTypes.Contains(type))
				return true;
			var uType = Nullable.GetUnderlyingType(type);
			if (uType!=null && uType != type)
				return IsSupported(uType);
			return false;
		}



		internal static string ToFqlIdentifier(this string s)
		{
			return StringHelper.SplitByCaps(s).StringConcat("").ToLower();
		}

		internal static string GetLinqTableName(this Type type)
		{
			if (type.IsSubclassOf(typeof(XTypedElement)))
			{
				if (type.Name == "facebookevent")
					return "event";
				else if (type.Name == "friend_info")
					return "friend";
				return type.Name;
			}
			var t = type.GetCustomAttributes(typeof(TableAttribute), true);
			if (t.Length > 0)
				return (t[0] as TableAttribute).Name;
			return null;
		}
	}
}
