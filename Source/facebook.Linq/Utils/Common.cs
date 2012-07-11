using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using System.ComponentModel;
using System.IO;

namespace Facebook
{

	public class DelegatedTextWriter : TextWriter
	{
		public DelegatedTextWriter()
		{
		}
		public DelegatedTextWriter(Action<string> writeMethod, Action<string> writeLineMethod)
		{
			WriteMethod = writeMethod;
			WriteLineMethod = writeLineMethod;
		}

		void InternalWrite(string message)
		{
			if (WriteMethod != null)
				WriteMethod(message);
		}
		void InternalWriteLine(string message)
		{
			if (WriteMethod != null)
				WriteLineMethod(message);
		}

		public Action<string> WriteMethod { get; set; }
		public Action<string> WriteLineMethod { get; set; }

		public override void Write(bool value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(char value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(char[] buffer)
		{
			InternalWrite(new String(buffer));
		}

		public override void Write(decimal value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(double value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(float value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(int value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(long value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(object value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(string value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(uint value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(ulong value)
		{
			InternalWrite(value.ToString());
		}

		public override void Write(string format, object arg0)
		{
			InternalWrite(String.Format(format, arg0));
		}

		public override void Write(string format, params object[] arg)
		{
			InternalWrite(String.Format(format, arg));
		}

		public override void Write(char[] buffer, int index, int count)
		{
			InternalWrite(new String(buffer, index, count));
		}

		public override void Write(string format, object arg0, object arg1)
		{
			InternalWrite(String.Format(format, arg0, arg1));
		}

		public override void Write(string format, object arg0, object arg1, object arg2)
		{
			InternalWrite(String.Format(format, arg0, arg1, arg2));
		}

		public override void WriteLine()
		{
			InternalWriteLine(String.Empty);
		}

		public override void WriteLine(bool value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(char value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(char[] buffer)
		{
			InternalWriteLine(new String(buffer));
		}

		public override void WriteLine(decimal value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(double value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(float value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(int value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(long value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(object value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(string value)
		{
			InternalWriteLine(value);
		}

		public override void WriteLine(uint value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(ulong value)
		{
			InternalWriteLine(value.ToString());
		}

		public override void WriteLine(string format, object arg0)
		{
			InternalWriteLine(String.Format(format, arg0));
		}

		public override void WriteLine(string format, params object[] arg)
		{
			InternalWriteLine(String.Format(format, arg));
		}

		public override void WriteLine(char[] buffer, int index, int count)
		{
			InternalWriteLine(new String(buffer, index, count));
		}

		public override void WriteLine(string format, object arg0, object arg1)
		{
			InternalWriteLine(String.Format(format, arg0, arg1));
		}

		public override void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			InternalWriteLine(String.Format(format, arg0, arg1, arg2));
		}

		public override Encoding Encoding
		{
			get { return Encoding.Default; }
		}

		public override void Flush()
		{
		}

		public override string NewLine
		{
			get
			{
				return "\n";
			}
			set
			{
				throw new NotImplementedException("TODO: Implement");
			}
		}

		public override IFormatProvider FormatProvider
		{
			get
			{
				return null;
			}
		}

	}

	internal static class DateHelper
	{
		// Methods
		internal static double? ConvertDateToDouble(DateTime? dateToConvert)
		{
			if (!dateToConvert.HasValue)
			{
				return null;
			}
			TimeSpan span = dateToConvert.Value - BaseUTCDateTime;
			return new double?(span.TotalSeconds);
		}

		internal static DateTime ConvertDoubleToDate(double secondsSinceEpoch)
		{
			return TimeZone.CurrentTimeZone.ToLocalTime(BaseUTCDateTime.AddSeconds(secondsSinceEpoch));
		}

		internal static DateTime ConvertDoubleToEventDate(double secondsSinceEpoch)
		{
			DateTime time = BaseUTCDateTime.AddSeconds(secondsSinceEpoch);
			int num = time.IsDaylightSavingTime() ? -7 : -8;
			return time.AddHours((double)num);
		}

		// Properties
		public static DateTime BaseUTCDateTime
		{
			get
			{
				return new DateTime(1970, 1, 1, 0, 0, 0);
			}
		}
	}

 


	internal sealed class StringHelper
	{
		private StringHelper()
		{
		}

		/// <summary>
		/// Convert a collection of strings to a comma separated list.
		/// </summary>
		/// <param name="collection">The collection to convert to a comma separated list.</param>
		/// <returns>comma separated string.</returns>
		internal static string ConvertToCommaSeparated(IList<string> collection)
		{
			// assumed that the average string length is 10 and double the buffer multiplying by 2
			// if this does not fit in your case, please change the values
			int preAllocation = collection.Count * 10 * 2;
			var sb = new StringBuilder(preAllocation);
			int i = 0;
			foreach (string key in collection)
			{
				sb.Append(key);
				if (i < collection.Count - 1)
					sb.Append(",");

				i++;
			}
			return sb.ToString();
		}
		/// <summary>
		/// Convert a collection of strings to a comma separated list.
		/// </summary>
		/// <param name="collection">The collection to convert to a comma separated list.</param>
		/// <returns>comma separated string.</returns>
		internal static string ConvertToCommaSeparated(IList<int?> collection)
		{
			//assumed that the average string length is 10 and double the buffer multiplying by 2
			// if this does not fit in your case, please change the values
			int preAllocation = collection.Count * 10 * 2;
			var sb = new StringBuilder(preAllocation);
			int i = 0;
			foreach (int? key in collection)
			{
				sb.Append(key.ToString());
				if (i < collection.Count - 1)
					sb.Append(",");

				i++;
			}
			return sb.ToString();
		}
		/// <summary>
		/// Convert a collection of strings to a comma separated list.
		/// </summary>
		/// <param name="collection">The collection to convert to a comma separated list.</param>
		/// <returns>comma separated string.</returns>
		internal static string ConvertToCommaSeparated(IList<int> collection)
		{

			//assumed that the average string length is 10 and double the buffer multiplying by 2
			//if this does not fit in your case, please change the values

			int preAllocation = collection.Count * 10 * 2;
			var sb = new StringBuilder(preAllocation);
			int i = 0;
			foreach (int key in collection)
			{
				sb.Append(key.ToString());
				if (i < collection.Count - 1)
					sb.Append(",");

				i++;
			}
			return sb.ToString();
		}

		internal static string ConvertToCommaSeparated(IList<long> collection)
		{

			//assumed that the average string length is 10 and double the buffer multiplying by 2
			//if this does not fit in your case, please change the values

			int preAllocation = collection.Count * 10 * 2;
			var sb = new StringBuilder(preAllocation);
			int i = 0;
			foreach (long key in collection)
			{
				sb.Append(key.ToString());
				if (i < collection.Count - 1)
					sb.Append(",");

				i++;
			}
			return sb.ToString();
		}

		internal static IEnumerable<string> SplitByCaps(string text)
		{
			//TODO: use string builder
			var sb = new StringBuilder();
			bool first = true;
			foreach (char c in text)
			{
				if (first)
					first = false;
				else
					if (Char.IsUpper(c))
					{
						yield return sb.ToString();
						sb.Length = 0;
					}
				sb.Append(c);
			}
			if (sb.Length > 0)
				yield return sb.ToString();
		}
	}


	static class EnumerableHelper
	{
		public static Type GetEnumerableItemType(object typedEnumerable)
		{
			var type = typedEnumerable.GetType();
			return GetEnumerableItemType(type);
		}
		public static Type GetEnumerableItemType(Type type)
		{
			var iface = type.GetInterface("System.Collections.Generic.IEnumerable`1");
			if (iface != null)
			{
				var args = iface.GetGenericArguments();
				return args[0];
			}
			return null;
		}
	}
	static class Extensions
	{


		/// <summary>
		/// Concatenates string values that are selected from an IEnumerable (e.g CSV parameter list, with ( and ) )
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="stringSelector"></param>
		/// <param name="prefix"></param>
		/// <param name="delim"></param>
		/// <param name="suffix"></param>
		/// <returns></returns>
		[DebuggerStepThrough]
		public static string StringConcat<T>(this IEnumerable<T> list, Func<T, string> stringSelector, string prefix, string delim, string suffix)
		{
			StringBuilder sb = new StringBuilder();
			if (!String.IsNullOrEmpty(prefix))
				sb.Append(prefix);
			bool first = true, hasDelim = !String.IsNullOrEmpty(delim);
			foreach (T item in list)
			{
				if (hasDelim)
				{
					if (first)
						first = false;
					else
						sb.Append(delim);
				}
				string s = stringSelector(item);
				if (!String.IsNullOrEmpty(s))
					sb.Append(s);
			}
			if (!String.IsNullOrEmpty(suffix))
				sb.Append(suffix);
			return sb.ToString();
		}

		/// <summary>
		/// Concatenates an IEnumerable of strings
		/// </summary>
		/// <param name="list"></param>
		/// <param name="prefix"></param>
		/// <param name="delim"></param>
		/// <param name="suffix"></param>
		/// <returns></returns>
		[DebuggerStepThrough]
		public static string StringConcat(this IEnumerable<string> list, string prefix, string delim, string suffix)
		{
			StringBuilder sb = new StringBuilder();
			if (!String.IsNullOrEmpty(prefix))
				sb.Append(prefix);
			bool first = true, hasDelim = !String.IsNullOrEmpty(delim);
			foreach (string item in list)
			{
				if (String.IsNullOrEmpty(item))
					continue;
				if (hasDelim)
				{
					if (first)
						first = false;
					else
						sb.Append(delim);
				}
				sb.Append(item);
			}
			if (!String.IsNullOrEmpty(suffix))
				sb.Append(suffix);
			return sb.ToString();
		}
		/// <summary>
		/// Concatenates an IEnumerable of strings
		/// </summary>
		/// <param name="list"></param>
		/// <param name="delim"></param>
		/// <returns></returns>
		[DebuggerStepThrough]
		public static string StringConcat(this IEnumerable<string> list, string delim)
		{
			return StringConcat(list, null, delim, null);
		}

		/// <summary>
		/// Returns true if the collection is empty
		/// </summary>
		/// <typeparam name="T">Collection item type</typeparam>
		/// <param name="collection">a collection of items</param>
		/// <returns>true if the collection contains no elements</returns>
		public static bool IsEmpty<T>(this IEnumerable<T> collection)
		{
			foreach (var i in collection)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Returns the symmetrical difference between two collections
		/// </summary>
		/// <remarks>
		/// Symmetrical difference is defined as the subtraction of the intersection from the union of the two collections
		/// </remarks>
		/// <typeparam name="T">Collection item type</typeparam>
		/// <param name="a">First collection</param>
		/// <param name="b">Second collection</param>
		/// <returns>a collection that has items that are exclusively in one of the collections</returns>
		public static IEnumerable<T> SymetricalDifference<T>(this IEnumerable<T> a, IEnumerable<T> b)
		{
			var union = a.Union(b);
			var intersection = a.Intersect(b);
			return union.Except(intersection);
		}

		/// <summary>
		/// Removes all items in Target that are not present in source, and Adds all items in Source that are not present in target
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target"></param>
		/// <param name="source"></param>
		public static void SetItems<T>(this IList<T> target, IEnumerable<T> source)
		{
			var targetHash = new HashSet<T>(target);
			var sourceHash = new HashSet<T>(source);
			var toDelete = targetHash.Except(sourceHash).ToList();
			var toAdd = sourceHash.Except(targetHash).ToList();
			foreach (var d in toDelete)
				target.Remove(d);
			foreach (var a in toAdd)
				target.Add(a);
		}


		///// <summary>
		///// SelectSingle, but a version that can traverse non-IEnumerables, like hierarchies
		///// </summary>
		///// <typeparam name="T"></typeparam>
		///// <typeparam name="S"></typeparam>
		///// <param name="seed"></param>
		///// <param name="NextSelector"></param>
		///// <param name="ValueSelector"></param>
		///// <returns></returns>
		/*public static List<S> AggregateToList<T, S>(this T seed, Func<T, T> NextSelector, Func<T, S> ValueSelector)
		{
			List<S> ret = new List<S>();
			while (seed != null)
			{
				ret.Add(ValueSelector(seed));
				seed = NextSelector(seed);
			}
			return ret;
		}*/

		/// <summary>
		/// Reverses a list in-place
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <returns></returns>
		public static List<T> InPlaceReverse<T>(this List<T> list)
		{
			list.Reverse();
			return list;
		}

		///// <summary>
		///// Maps a source collection, using a mapping function, into a new List.
		///// </summary>
		///// <example>
		///// object[] src = new object[] {1,"2",3,"4","5"}
		///// List&lt;int&gt; values = src.Map(v=>(v is int) ? (int)v : Int32.Parse(v.ToString()))
		///// </example>
		///// <typeparam name="T"></typeparam>
		///// <typeparam name="S"></typeparam>
		///// <param name="source"></param>
		///// <param name="mapping"></param>
		///// <returns></returns>
		//public static List<S> Map<T, S>(this IEnumerable<T> source, Func<T, S> mapping)
		//{
		//  List<S> list = new List<S>();
		//  if (source != null)
		//  {
		//    foreach (T item in source)
		//    {
		//      S mappedItem = mapping(item);
		//      list.Add(mappedItem);
		//    }
		//  }
		//  return list;
		//}

		/// <summary>
		/// Same as Map, but with a condition predicate
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="S"></typeparam>
		/// <param name="source"></param>
		/// <param name="mapping"></param>
		/// <param name="condition"></param>
		/// <returns></returns>
		public static List<S> Map<T, S>(this IEnumerable<T> source, Func<T, S> mapping, Predicate<T> condition)
		{
			List<S> list = new List<S>();
			foreach (T item in source)
			{
				if (!condition(item))
					continue;
				S mappedItem = mapping(item);
				if (mappedItem != null)
					list.Add(mappedItem);
			}
			return list;
		}

		public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> list)
		{
			foreach (T item in list)
				set.Add(item);
		}

		public static Dictionary<T, S> MapToDictionary<T, S>(this IEnumerable<T> source, Func<T, S> valueSelector)
		{
			Dictionary<T, S> ret = new Dictionary<T, S>();
			foreach (T item in source)
			{
				ret.Add(item, valueSelector(item));
			}
			return ret;
		}

		public static void RemoveKeysWithValue<T, S>(this Dictionary<T, S> source, S value)
		{
			List<T> matchingKeys = new List<T>();
			foreach (T key in source.Keys)
			{
				if (source[key].Equals(value))
					matchingKeys.Add(key);
			}
			foreach (T key in matchingKeys)
				source.Remove(key);
		}

		public static void KeepOnlyKeysWithValue<T, S>(this IDictionary<T, S> source, S value)
		{
			List<T> matchingKeys = new List<T>();
			foreach (T key in source.Keys)
			{
				if (!source[key].Equals(value))
					matchingKeys.Add(key);
			}
			foreach (T key in matchingKeys)
				source.Remove(key);
		}
		public static T TryGetValue<K, T>(this Dictionary<K, T> dictionary, K key)
		{
			T value;
			dictionary.TryGetValue(key, out value);
			return value;
		}
		public static bool IsNullOrEmpty(this string s)
		{
			return String.IsNullOrEmpty(s);
		}
		public static bool IsNotNullOrEmpty(this string s)
		{
			return !String.IsNullOrEmpty(s);
		}


	}

	static class ReflectionHelper
	{
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return (T)type.GetCustomAttributes(typeof(T), false).FirstOrDefault();
		}
		public static T GetCustomAttribute<T>(this Type type, bool inherit) where T : Attribute
		{
			return (T)type.GetCustomAttributes(typeof(T), inherit).FirstOrDefault();
		}

		//public static string Get
		public static T CreateSpecificOrDefaultInstance<T>(string typeName, params object[] prms)
		{
			Type type;
			if (typeName != null)
			{
				type = Type.GetType(typeName);
			}
			else
			{
				type = typeof(T);
			}
			T instance = (T)Activator.CreateInstance(type, prms);
			return instance;
		}

		public static Type ClimbUp(Type type)
		{
			if (type.IsGenericType && !type.IsGenericTypeDefinition)
			{
				return type.GetGenericTypeDefinition();
			}
			return type.BaseType;
		}

		public static object GetDefaultValue(Type type)
		{
			if (type.IsValueType)
			{
				return Activator.CreateInstance(type);
			}
			else
				return null;
		}

		public static Type GetMemberType(MemberInfo mi)
		{
			if (mi is FieldInfo)
				return ((FieldInfo)mi).FieldType;
			return ((PropertyInfo)mi).PropertyType;
		}


		public static object GetMemberValue(MemberInfo mi, object obj)
		{
			if (mi is FieldInfo)
				return ((FieldInfo)mi).GetValue(obj);
			return ((PropertyInfo)mi).GetValue(obj, null);
		}

		public static void SetMemberValue(MemberInfo mi, object obj, object value)
		{
			if (mi is FieldInfo)
				((FieldInfo)mi).SetValue(obj, value);
			else
				((PropertyInfo)mi).SetValue(obj, value, null);
		}


		public static object CreateGenericInstance(Type type, object[] args, params Type[] genericParameters)
		{
			Type genericType = type.MakeGenericType(genericParameters);
			object obj = Activator.CreateInstance(genericType, args);
			return obj;
		}

		//private static Type _GetCollectionItemType(Type collectionType)
		//{
		//  PropertyInfo[] pis = collectionType.GetProperties();
		//  foreach (PropertyInfo pi in pis)
		//  {
		//    if (pi.Name == "Item")
		//    {
		//      return pi.PropertyType;
		//    }
		//  }
		//  return null;
		//}


		//public static Type GetCollectionItemType(Type listType)
		//{
		//  if (listType.IsArray)
		//  {
		//    return listType.GetElementType();
		//  }
		//  else
		//  {
		//    return _GetCollectionItemType(listType);
		//  }
		//}

		//public static T GetAttributes<T>(Assembly asm)
		//{
		//}

		public static IList<T> GetAttributes<T>(ICustomAttributeProvider mi, bool inherit) where T : Attribute //TODO: Optimize (cache attribute access)
		{
			object[] attributes = mi.GetCustomAttributes(typeof(T), inherit);
			List<T> list = new List<T>();
			foreach (T attribute in attributes)
			{
				list.Add(attribute);
			}
			return list;
		}

		public static T GetAttribute<T>(ICustomAttributeProvider mi, bool inherit) where T : Attribute //TODO: Optimize (cache attribute access)
		{
			IList<T> list = GetAttributes<T>(mi, inherit);
			if (list.Count == 0)
				return null;
			return list[0];
		}

		public static T GetAttribute<T>(ICustomAttributeProvider mi) where T : Attribute //TODO: Optimize (cache attribute access)
		{
			return GetAttribute<T>(mi, true);
		}

		public static bool IsCollection(Type realType)
		{
			if (typeof(IList).IsAssignableFrom(realType))
				return true;
			return false;
		}

		public static bool IsNullable(Type type)
		{
			if (type.IsValueType)
			{
				if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable))
					return true;
				return false;
			}
			return true;
		}

		public static T GetAttribute<T>(Assembly asm) where T : Attribute
		{
			object[] list = asm.GetCustomAttributes(typeof(T), false);
			if (list.Length > 0)
				return (T)list[0];
			return null;
		}


		public static Type GetFirstGenericType(Type type)
		{
			Type[] types = type.GetGenericArguments();
			if (types.Length == 0)
			{
				type = type.BaseType;
				if (type != null)
					return GetFirstGenericType(type);
				return null;
			}
			return types[0];
		}



		public static object InvokeMethod(object instance, string methodName, object[] prms)
		{
			MethodInfo mi = instance.GetType().GetMethod(methodName);
			object result = mi.Invoke(instance, prms);
			return result;
		}

		public static object TryInvokeMethodWithParams(object obj, string methodName, object[] prms)
		{
			var types = Type.GetTypeArray(prms);
			MethodInfo mi = obj.GetType().GetMethod(methodName, types);
			if (mi == null)
				return null;
			object result = mi.Invoke(obj, prms);
			return result;
		}
		//Instance
		public static object GetPropertyValue(object instance, string propertyName)
		{
			return instance.GetType().GetProperty(propertyName).GetValue(instance, null);
		}

		//Static
		public static object GetPropertyValue(Type T, string propertyName)
		{
			return T.GetProperty(propertyName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).GetValue(null, null);
		}
		public static object GetFieldValue(object instance, string fieldName)
		{
			return instance.GetType().GetField(fieldName).GetValue(instance);
		}

		public static void SetFieldValue(object obj, string fieldName, object value)
		{
			obj.GetType().GetField(fieldName).SetValue(obj, value);
		}



		public static bool IsStatic(MemberInfo mi)
		{
			PropertyInfo pi = mi as PropertyInfo;
			if (pi != null)
			{
				return pi.GetAccessors()[0].IsStatic;
			}
			FieldInfo fi = mi as FieldInfo;
			if (fi != null)
			{
				return fi.IsStatic;
			}
			throw new NotSupportedException("couldn't determine if memberinfo is static");
		}

		public static bool IsPublic(MemberInfo mi)
		{
			PropertyInfo pi = mi as PropertyInfo;
			if (pi != null)
			{
				return pi.GetAccessors()[0].IsPublic;
			}
			FieldInfo fi = mi as FieldInfo;
			if (fi != null)
			{
				return fi.IsPublic;
			}
			throw new NotSupportedException("couldn't determine if memberinfo is public");
		}


		public static bool IsDefaultValue(Type type, object value)
		{
			var def = GetDefaultValue(type);
			return Object.Equals(def, value);
		}
	}
}
