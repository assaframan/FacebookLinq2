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
	public class Fid
	{
		public long? Value { get; set; }

		public Fid(long? value)
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


	// user id
	[DebuggerDisplay("{Value}")]
	public class Uid : Fid
	{
		public Uid(long? value) : base(value) {}
	}

	// application id
	[DebuggerDisplay("{Value}")]
	public class AppId : Fid
	{
		public AppId(long? value) : base(value) { }
	}

	// domain id
	[DebuggerDisplay("{Value}")]
	public class DomainId : Fid
	{
		public DomainId(long? value) : base(value) { }
	}

	// Status id
	[DebuggerDisplay("{Value}")]
	public class StatusId : Fid
	{
		public StatusId(long? value) : base(value) { }
	}
	


	// request id
	[DebuggerDisplay("{Value}")]
	public class RequestId : Fid
	{
		public RequestId(long? value) : base(value) { }
	}

	// Checkin id
	[DebuggerDisplay("{Value}")]
	public class CheckinId : Fid
	{
		public CheckinId(long? value) : base(value) { }
	}

	// Page id
	[DebuggerDisplay("{Value}")]
	public class PageId : Fid
	{
		public PageId(long? value) : base(value) { }
	}

	// Post id
	[DebuggerDisplay("{Value}")]
	public class PostId : Fid
	{
		public PostId(long? value) : base(value) { }
	}	

	// Event id
	[DebuggerDisplay("{Value}")]
	public class EventId : Fid
	{
		public EventId(long? value) : base(value) { }
	}

	// friend list id
	[DebuggerDisplay("{Value}")]
	public class FriendListId : Fid
	{
		public FriendListId(long? value) : base(value) { }
	}

	// link id
	[DebuggerDisplay("{Value}")]
	public class LinkId : Fid
	{
		public LinkId(long? value) : base(value) { }
	}

	// group list id
	[DebuggerDisplay("{Value}")]
	public class GroupId : Fid
	{
		public GroupId(long? value) : base(value) { }
	}

	// thread id
	[DebuggerDisplay("{Value}")]
	public class ThreadId : Fid
	{
		public ThreadId(long? value) : base(value) { }
	}

	// notification id
	[DebuggerDisplay("{Value}")]
	public class NotificationId : Fid
	{
		public NotificationId(long? value) : base(value) { }
	}

	// Offer id
	[DebuggerDisplay("{Value}")]
	public class OfferId : Fid
	{
		public OfferId(long? value) : base(value) { }
	}

	// milestone id
	[DebuggerDisplay("{Value}")]
	public class MilestoneId : Fid
	{
		public MilestoneId(long? value) : base(value) { }
	}

	// photo id
	[DebuggerDisplay("{Value}")]
	public class PhotoId : Fid
	{
		public PhotoId(long? value) : base(value) { }
	}

	// review id
	[DebuggerDisplay("{Value}")]
	public class ReviewId : Fid
	{
		public ReviewId(long? value) : base(value) { }
	}

	// message id
	[DebuggerDisplay("{Value}")]
	public class MessageId : Fid
	{
		public MessageId(long? value) : base(value) { }
	}

	// video id
	[DebuggerDisplay("{Value}")]
	public class VideoId : Fid
	{
		public VideoId(long? value) : base(value) { }
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


