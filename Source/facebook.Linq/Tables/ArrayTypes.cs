using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using Facebook;
using System.Diagnostics;

namespace facebook.Tables
{
	public enum FolderId
	{
		 Inbox		= 0,
		 Outbox		= 1, 
		 Updates	= 4,
	}
	
	public enum StreamType
	{
		GroupCreated				= 11,
		EventCreated				= 12,
		StatusUpdate				= 46,
		PostOnWallFromAnotherUser	= 56,
		NoteCreated					= 66,
		LinkPosted					= 80,
		VideoPosted					= 128,
		PhotosPosted				= 247,
		AppStory_1					= 237,
		CommentCreated				= 257,
		AppStory_2					= 272,
		CheckinToPlace				= 285,
		PostInGroup					= 308,
	}

	[DebuggerDisplay("Latitude = {Latitude} | Longitude = {Longitude};")]
	public class Coords
	{
		[Column(Name = "latitude")]
		public double? Latitude { get; set; }
		[Column(Name = "longitude")]
		public double? Longitude { get; set; }

		public Coords()
		{

		}

		public Coords(JsonObject jsonValue)
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

	public class Venue : Coords
	{
		[Column(Name = "street")]
		public string Street { get; set; }
		[Column(Name = "city")]
		public string City { get; set; }
		[Column(Name = "state")]
		public string State { get; set; }
		[Column(Name = "zip")]
		public long Zip { get; set; }

		public Venue()
		{

		}

		public Venue(JsonObject jsonValue) : base(jsonValue)	
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

	[DebuggerDisplay("CanLike = {CanLike} | LikeCount = {LikeCount} | UserLikes = {UserLikes}")]
	public class LikeInfo
	{
		[Column(Name = "can_like")]
		public bool CanLike { get; set; }
		[Column(Name = "like_count")]
		public long LikeCount { get; set; }
		[Column(Name = "user_likes")]
		public bool UserLikes { get; set; }

		public LikeInfo()
		{

		}

		public LikeInfo(JsonObject jsonValue)
		{
			if (jsonValue.ContainsKey("can_like"))
			{
				CanLike = (bool)jsonValue["can_like"];
			}
			if (jsonValue.ContainsKey("like_count"))
			{
				LikeCount = (long)jsonValue["like_count"];
			}
			if (jsonValue.ContainsKey("user_likes"))
			{
				UserLikes = (bool)jsonValue["user_likes"];
			}
		}

	}


	[DebuggerDisplay("CanComment = {CanComment} | CommentCount = {CommentCount}")]
	public class CommentInfo
	{
		[Column(Name = "can_comment")]
		public bool CanComment { get; set; }
		[Column(Name = "comment_count")]
		public long CommentCount { get; set; }

		public CommentInfo()
		{

		}

		public CommentInfo(JsonObject jsonValue)
		{
			if (jsonValue.ContainsKey("can_comment"))
			{
				CanComment = (bool)jsonValue["can_comment"];
			}
			if (jsonValue.ContainsKey("comment_count"))
			{
				CommentCount = (long)jsonValue["comment_count"];
			}
		}

	}


	
	[DebuggerDisplay("{Value}")]
	public class Fid
	{
		public String Value { get; set; }

		public Fid(String value)
		{
			Value = value;
		}
		public override bool Equals(System.Object obj)
		{
			// If parameter cannot be cast to Point return false.
			Fid other = obj as Fid;

			// Return true if the fields match:
			return this.Value == other.Value;
		}
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}
	}

	// UnionId
	[DebuggerDisplay("{Value}")]
	public class UnionId : Fid
	{
		public UnionId(string value) : base(value) { }
		public static implicit operator PostId(UnionId d)
		{
			return new PostId(d.Value);
		}
		public static implicit operator VideoId(UnionId d)
		{
			return new VideoId(d.Value);
		}
		public static implicit operator NoteId(UnionId d)
		{
			return new NoteId(d.Value);
		}
		public static implicit operator LinkId(UnionId d)
		{
			return new LinkId(d.Value);
		}
		public static implicit operator PhotoId(UnionId d)
		{
			return new PhotoId(d.Value);
		}
		public static implicit operator AlbumId(UnionId d)
		{
			return new AlbumId(d.Value);
		}
		public static implicit operator GroupId(UnionId d)
		{
			return new GroupId(d.Value);
		}
		public static implicit operator Uid(UnionId d)
		{
			return new Uid(d.Value);
		}
		public static implicit operator EventId(UnionId d)
		{
			return new EventId(d.Value);
		}
	}

	public class SubjectId : Fid
	{
		public SubjectId(string value) : base(value) { }
		public static implicit operator Uid(SubjectId d)
		{
			return new Uid(d.Value);
		}
		public static implicit operator EventId(SubjectId d)
		{
			return new EventId(d.Value);
		}
		public static implicit operator GroupId(SubjectId d)
		{
			return new GroupId(d.Value);
		}

	}


	// user id
	[DebuggerDisplay("{Value}")]
	public class Uid : Fid
	{
		public Uid(string value) : base(value) {}
	}

	// application id
	[DebuggerDisplay("{Value}")]
	public class AppId : Fid
	{
		public AppId(string value) : base(value) { }
	}

	// domain id
	[DebuggerDisplay("{Value}")]
	public class DomainId : Fid
	{
		public DomainId(string value) : base(value) { }
	}

	// Status id
	[DebuggerDisplay("{Value}")]
	public class StatusId : Fid
	{
		public StatusId(string value) : base(value) { }
	}
	


	// request id
	[DebuggerDisplay("{Value}")]
	public class RequestId : Fid
	{
		public RequestId(string value) : base(value) { }
	}

	// Checkin id
	[DebuggerDisplay("{Value}")]
	public class CheckinId : Fid
	{
		public CheckinId(string value) : base(value) { }
	}

	// Page id
	[DebuggerDisplay("{Value}")]
	public class PageId : Fid
	{
		public PageId(string value) : base(value) { }
	}

	// Post id
	[DebuggerDisplay("{Value}")]
	public class PostId : Fid
	{
		public PostId(string value) : base(value) { }
	}	

	// Event id
	[DebuggerDisplay("{Value}")]
	public class EventId : Fid
	{
		public EventId(string value) : base(value) { }
	}

	// friend list id
	[DebuggerDisplay("{Value}")]
	public class FriendListId : Fid
	{
		public FriendListId(string value) : base(value) { }
	}

	// link id
	[DebuggerDisplay("{Value}")]
	public class LinkId : Fid
	{
		public LinkId(string value) : base(value) { }
	}

	// group list id
	[DebuggerDisplay("{Value}")]
	public class GroupId : Fid
	{
		public GroupId(string value) : base(value) { }
	}

	// thread id
	[DebuggerDisplay("{Value}")]
	public class ThreadId : Fid
	{
		public ThreadId(string value) : base(value) { }
	}

	// notification id
	[DebuggerDisplay("{Value}")]
	public class NotificationId : Fid
	{
		public NotificationId(string value) : base(value) { }
	}

	// Offer id
	[DebuggerDisplay("{Value}")]
	public class OfferId : Fid
	{
		public OfferId(string value) : base(value) { }
	}

	// milestone id
	[DebuggerDisplay("{Value}")]
	public class MilestoneId : Fid
	{
		public MilestoneId(string value) : base(value) { }
	}

	// photo id
	[DebuggerDisplay("{Value}")]
	public class PhotoId : Fid
	{
		public PhotoId(string value) : base(value) { }
	}

	// review id
	[DebuggerDisplay("{Value}")]
	public class ReviewId : Fid
	{
		public ReviewId(string value) : base(value) { }
	}

	// message id
	[DebuggerDisplay("{Value}")]
	public class MessageId : Fid
	{
		public MessageId(string value) : base(value) { }
	}

	// video id
	[DebuggerDisplay("{Value}")]
	public class VideoId : Fid
	{
		public VideoId(string value) : base(value) { }
	}

	// comment id
	[DebuggerDisplay("{Value}")]
	public class CommentId : Fid
	{
		public CommentId(string value) : base(value) { }
	}

	// Object Url id
	[DebuggerDisplay("{Value}")]
	public class ObjectUrlId : Fid
	{
		public ObjectUrlId(string value) : base(value) { }
	}

	// Profile id
	[DebuggerDisplay("{Value}")]
	public class ProfileId : Fid
	{
		public ProfileId(string value) : base(value) { }
	}

	// Question id
	[DebuggerDisplay("{Value}")]
	public class QuestionId : Fid
	{
		public QuestionId(string value) : base(value) { }
	}

	// Question Option id
	[DebuggerDisplay("{Value}")]
	public class QuestionOptionId : Fid
	{
		public QuestionOptionId(string value) : base(value) { }
	}

	// note id
	[DebuggerDisplay("{Value}")]
	public class NoteId : Fid
	{
		public NoteId(string value) : base(value) { }
	}

	// Connection target id
	[DebuggerDisplay("{Value}")]
	public class ConnectionTargetId : Fid
	{
		public ConnectionTargetId(string value) : base(value) { }

		public static implicit operator Uid(ConnectionTargetId d)
		{
			return new Uid(d.Value);
		}
		public static implicit operator PageId(ConnectionTargetId d)
		{
			return new PageId(d.Value);
		}
	}

	// domain owner id
	[DebuggerDisplay("{Value}")]
	public class DomainOwnerId : Fid
	{
		public DomainOwnerId(string value) : base(value) { }

		public static implicit operator Uid(DomainOwnerId d)
		{
			return new Uid(d.Value);
		}
		public static implicit operator PageId(DomainOwnerId d)
		{
			return new PageId(d.Value);
		}
		public static implicit operator AppId(DomainOwnerId d)
		{
			return new AppId(d.Value);
		}
	}


	// Stream target id
	[DebuggerDisplay("{Value}")]
	public class StreamTargetId : Fid
	{
		public StreamTargetId(string value) : base(value) { }

		public static implicit operator Uid(StreamTargetId d)
		{
			return new Uid(d.Value);
		}
		public static implicit operator PageId(StreamTargetId d)
		{
			return new PageId(d.Value);
		}
		public static implicit operator GroupId(StreamTargetId d)
		{
			return new GroupId(d.Value);
		}
		public static implicit operator EventId(StreamTargetId d)
		{
			return new EventId(d.Value);
		}
	}

	// Album id
	[DebuggerDisplay("{Value}")]
	public class AlbumId : Fid
	{
		public AlbumId(string value) : base(value) { }
	}	
	
	// third_party_id
	[DebuggerDisplay("{Value}")]
	public class ThirdPartyId : Fid
	{
		public ThirdPartyId(string value) : base(value) { }
	}

	// xid
	[DebuggerDisplay("{Value}")]
	public class Xid : Fid
	{
		public Xid(string value) : base(value) { }
	}

	// object id
	[DebuggerDisplay("{Value}")]
	public class ObjectId : Fid
	{
		public ObjectId(string value) : base(value) { }

		public static implicit operator Xid(ObjectId d)   
		{
			return new Xid(d.Value);
		}

	}

	public class FromJsonList<T> : List<T>
	{
		public FromJsonList()
		{

		}
		public FromJsonList(JsonArray jsonArray)
		{
			foreach (var val in jsonArray)
			{
				Add(AllocateVal(val));
			}
		}
		virtual protected T AllocateVal(object val)
		{
			return (T)val;
		}
	}


	public class UidsList : FromJsonList<Uid> 
	{
		public UidsList(){}
		public UidsList(JsonArray jsonArray) :base(jsonArray) { }

		override protected Uid AllocateVal(object val)
		{
			if(val is string)
			{
				return new Uid((string)val);
			}
			else
			{
				return new Uid(val.ToString());

			}
		}
	};

	public class Urls : FromJsonList<string>
	{
		public Urls() { }
		public Urls(JsonArray jsonArray) : base(jsonArray) { }
	};

	public class Genders : FromJsonList<string>
	{
		public Genders() { }
		public Genders(JsonArray jsonArray) : base(jsonArray) { }
	};

	public class Developers : FromJsonList<string>
	{
		public Developers() { }
		public Developers(JsonArray jsonArray) : base(jsonArray) { }
	};

	public class AppDomains : FromJsonList<string>
	{
		public AppDomains() { }
		public AppDomains(JsonArray jsonArray) : base(jsonArray) { }
	};

	public class Auths : FromJsonList<string>
	{
		public Auths() { }
		public Auths(JsonArray jsonArray) : base(jsonArray) { }
	};
	

	



	public class Device
	{
		[Column(Name = "os")]
		public string Os { get; set; }
		[Column(Name = "hardware")]
		public string Hardware { get; set; }

		public Device()
		{

		}

		public Device(JsonObject jsonValue)
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
	
	
	public class Devices : List<Device>
	{
		public Devices() { }
		public Devices(JsonArray jsonArray)
		{
 			foreach(JsonObject obj in jsonArray)
			{
				Add(new Device(obj));
			}
		}
	};

	public class Tag
	{
		[Column(Name = "id")]
		public UnionId Id { get; set; }
		[Column(Name = "name")]
		public string Name { get; set; }
		[Column(Name = "offset")]
		public long Offset { get; set; }
		[Column(Name = "length")]
		public long Length { get; set; }
		[Column(Name = "type")]
		public string ObjectType { get; set; }

		public Tag()
		{

		}

		public Tag(JsonObject jsonValue)
		{
			if (jsonValue.ContainsKey("id"))
			{
				Id = new UnionId(((long)jsonValue["id"]).ToString());
			}
			if (jsonValue.ContainsKey("name"))
			{
				Name = (string)jsonValue["name"];
			}
			if (jsonValue.ContainsKey("offset"))
			{
				Offset = (long)jsonValue["offset"];
			}
			if (jsonValue.ContainsKey("length"))
			{
				Length = (long)jsonValue["length"];
			}
			if (jsonValue.ContainsKey("type"))
			{
				ObjectType = (string)jsonValue["type"];
			}
		}

	}

	public class Tags : List<Tag>
	{
		public Tags() { }
		public Tags(JsonArray jsonArray)
		{
			foreach (JsonArray arr in jsonArray)
			{
				foreach (JsonObject obj in arr)
				{
					Add(new Tag(obj));
				}
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


