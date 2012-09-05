using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using Facebook;
using System.Diagnostics;

namespace facebook.Tables
{
	public class CoordsType
	{
		[Column(Name = "latitude")]
		public double? Latitude { get; set; }
		[Column(Name = "longitude")]
		public double? Longitude { get; set; }

		public CoordsType()
		{

		}

		public CoordsType(JsonObject jsonValue)
		{
			if (jsonValue.ContainsKey("latitude"))
			{
				Latitude = (double)jsonValue["latitude"];
			}
			if (jsonValue.ContainsKey("longitude"))
			{
				Longitude = (double)jsonValue["longitude"];
			}
		}

	}


	/// The venue where the event being queried is being held. Contains one or more of the following fields:
	/// 
	/// <code>street</code>, 
	/// <code>city</code>, 
	/// <code>state</code>, 
	/// <code>zip</code>, 
	/// <code>country</code>, 
	/// <code>latitude</code>
	/// <code>longitude</code>.

	public class VenueType : CoordsType
	{
		[Column(Name = "street")]
		public string Street { get; set; }
		[Column(Name = "city")]
		public string City { get; set; }
		[Column(Name = "state")]
		public string State { get; set; }
		[Column(Name = "zip")]
		public long Zip { get; set; }

		public VenueType()
		{

		}

		public VenueType(JsonObject jsonValue) : base(jsonValue)	
		{
			if (jsonValue.ContainsKey("street"))
			{
				Street = (string)jsonValue["street"];
			}
			if (jsonValue.ContainsKey("city"))
			{
				City = (string)jsonValue["city"];
			}
			if (jsonValue.ContainsKey("state"))
			{
				State = (string)jsonValue["state"];
			}
			if (jsonValue.ContainsKey("zip"))
			{
				Zip = (long)jsonValue["zip"];
			}
		}

	}
	
	
	public class FromJsonList<T> : List<T>
	{
		public FromJsonList()
		{

		}
		public FromJsonList(JsonArray jsonArray)
		{
			foreach(var val in jsonArray)
			{
				Add(AllocateVal(val));
			}
		}
		virtual protected T AllocateVal(object val)
		{
			return (T)val;
		}
	}

	[DebuggerDisplay("{Value}")]
	public class Uid
	{
		public long? Value { get; set; }

		public Uid(long? value)
		{
			Value = value;
		}
		public override bool Equals(System.Object obj)
		{
			// If parameter cannot be cast to Point return false.
			Uid other = obj as Uid;

			// Return true if the fields match:
			return this.Value == other.Value;
		}
	}
	public class UidsList : FromJsonList<Uid> 
	{
		public UidsList(){}
		public UidsList(JsonArray jsonArray) :base(jsonArray) { }

		override protected Uid AllocateVal(object val)
		{
			return new Uid((long?)val);
		}
	};

	public class UrlList : FromJsonList<string>
	{
		public UrlList() { }
		public UrlList(JsonArray jsonArray) : base(jsonArray) { }
	};

	public class GenderList : FromJsonList<string>
	{
		public GenderList() { }
		public GenderList(JsonArray jsonArray) : base(jsonArray) { }
	};



	public class DeviceType
	{
		[Column(Name = "os")]
		public string Os { get; set; }
		[Column(Name = "hardware")]
		public string Hardware { get; set; }

		public DeviceType()
		{

		}

		public DeviceType(JsonObject jsonValue)
		{
			if (jsonValue.ContainsKey("os"))
			{
				Os = (string)jsonValue["os"];
			}
			if (jsonValue.ContainsKey("hardware"))
			{
				Hardware = (string)jsonValue["hardware"];
			}
		}

	}
	
	
	public class DeviceList : List<DeviceType>
	{
		public DeviceList() { }
		public DeviceList(JsonArray jsonArray)
		{
 			foreach(JsonObject obj in jsonArray)
			{
				Add(new DeviceType(obj));
			}
		}
	};

	public class HometownLocationType 
	{
		[Column(Name = "id")]
		public long Id { get; set; }
		[Column(Name = "street")]
		public string Street { get; set; }
		[Column(Name = "city")]
		public string City { get; set; }
		[Column(Name = "state")]
		public string State { get; set; }
		[Column(Name = "zip")]
		public long? Zip { get; set; }
		[Column(Name = "country")]
		public string Country { get; set; }
		[Column(Name = "name")]
		public string Name { get; set; }

		public HometownLocationType()
		{

		}

		public HometownLocationType(JsonObject jsonValue)
		{
			if (jsonValue.ContainsKey("street"))
			{
				Street = (string)jsonValue["street"];
			}
			if (jsonValue.ContainsKey("city"))
			{
				City = (string)jsonValue["city"];
			}
			if (jsonValue.ContainsKey("state"))
			{
				State = (string)jsonValue["state"];
			}
			if (jsonValue.ContainsKey("zip"))
			{
				string zipAsString = (string)jsonValue["zip"];
				if(zipAsString == "")
				{
					Zip = null;
				}
				else
				{
					Zip = long.Parse(zipAsString);
				}
			}
			if (jsonValue.ContainsKey("country"))
			{
				Country = (string)jsonValue["country"];
			}
			if (jsonValue.ContainsKey("id"))
			{
				Id = (long)jsonValue["id"];
			}
			if (jsonValue.ContainsKey("name"))
			{
				Name = (string)jsonValue["name"];
			}


		}

	}


}


