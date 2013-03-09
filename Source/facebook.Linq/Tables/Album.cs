using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;
using Facebook;

namespace facebook.Tables
{
    /// <summary>
    /// https://developers.facebook.com/docs/reference/fql/album
    /// </summary>
    [Table(Name = "album")]
    public class Album
    {
        /// <summary>
        /// The album ID
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "aid" , IsPrimaryKey = true)]
        public AlbumId Aid { get; set; }

        /// <summary>
        /// Time that the album is backdated to
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "backdated_time" )]
        public DateTime? BackdatedTime { get; set; }

        /// <summary>
        /// Can the album be backdated on Timeline
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_backdate" )]
        public bool? CanBackdate { get; set; }

        /// <summary>
        /// Determines whether a given UID can upload to the album. It is true if the following conditions are met: The user owns the album, the album is not a special album like the profile pic album, the album is not full.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_upload" )]
        public bool? CanUpload { get; set; }

        /// <summary>
        /// The comment information of the album being queried. This is an object containing can_comment and comment_count
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "comment_info" )]
        public CommentInfo CommentInfo { get; set; }

        /// <summary>
        /// The album cover photo object_id
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "cover_object_id" )]
        public ObjectId CoverObjectId { get; set; }

        /// <summary>
        /// The album cover photo ID string
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "cover_pid" )]
        public string CoverPid { get; set; }

        /// <summary>
        /// The time the photo album was initially created expressed as UNIX time.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created" )]
        public object Created { get; set; }

        /// <summary>
        /// The description of the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The URL for editing the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "edit_link" )]
        public string EditLink { get; set; }

        /// <summary>
        /// Determines whether or not the album should be shown to users.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_user_facing" )]
        public bool? IsUserFacing { get; set; }

        /// <summary>
        /// The like information of the album being queried. This is an object containing can_like, like_count, and user_likes
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "like_info" )]
        public LikeInfo LikeInfo { get; set; }

        /// <summary>
        /// A link to this album on Facebook
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// The location of the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "location" )]
        public string Location { get; set; }

        /// <summary>
        /// The last time the photo album was updated expressed as UNIX time.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "modified" )]
        public object Modified { get; set; }

        /// <summary>
        /// Indicates the time a major update (like addition of photos) was last made to the album expressed as UNIX time.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "modified_major" )]
        public object ModifiedMajor { get; set; }

        /// <summary>
        /// The title of the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The object_id of the album on Facebook. This is used to identify the equivalent Album object in the Graph API. You can also use the object_id to let users comment on an album with the Graph API Comments
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "object_id" )]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// The user ID of the owner of the album
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// Cursor for the owner field
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "owner_cursor" )]
        public string OwnerCursor { get; set; }

        /// <summary>
        /// The number of photos in the album
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "photo_count" )]
        public object PhotoCount { get; set; }

        /// <summary>
        /// Facebook ID of the place associated with the album, if any.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "place_id" )]
        public object PlaceId { get; set; }

        /// <summary>
        /// The type of photo album. Can be one of profile: The album containing profile pictures, mobile: The album containing mobile uploaded photos, wall: The album containing photos posted to a user's Wall, normal: For all other albums.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The number of videos in the album
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "video_count" )]
        public object VideoCount { get; set; }

        /// <summary>
        /// Visible only to the album owner. Indicates who can see the album. The value can be one of friends, friends-of-friends, networks, everyone, custom (if the visibility doesn't match any of the other values)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "visible" )]
        public string Visible { get; set; }

        /// <summary>
        /// The number of photos in this album
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "size" )]
        public object Size { get; set; }

    }
}
