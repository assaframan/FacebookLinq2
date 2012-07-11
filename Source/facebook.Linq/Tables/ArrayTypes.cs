using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using Facebook;

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
				Add((T)val);
			}
		}
	}

	public class UidsList : FromJsonList<long> 
	{
		public UidsList(){}
		public UidsList(JsonArray jsonArray) :base(jsonArray) { }
	};

	public class UrlList : FromJsonList<string>
	{
		public UrlList() { }
		public UrlList(JsonArray jsonArray) : base(jsonArray) { }
	};

}
