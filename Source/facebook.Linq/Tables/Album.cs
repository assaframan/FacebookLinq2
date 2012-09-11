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
    /// http://developers.facebook.com/docs/reference/fql/album/
    /// </summary>
    [Table(Name = "album")]
    public class Album
    {
        /// <summary>
        /// The album ID
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "aid" , IsPrimaryKey = true)]
        public AlbumId Aid { get; set; }

        /// <summary>
        /// The object_id of the album on Facebook. This is used to identify the equivalent Album object in the Graph API. You can also use the object_id to let users comment on an album with the Graph API Comments
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "object_id" )]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// The user ID of the owner of the album
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// The album cover photo ID string
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "cover_pid" )]
        public string CoverPid { get; set; }

        /// <summary>
        /// The album cover photo object_id
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "cover_object_id" )]
        public ObjectId CoverObjectId { get; set; }

        /// <summary>
        /// The title of the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The time the photo album was initially created expressed as a unix time.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created" )]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last time the photo album was updated expressed as a unix time.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "modified" )]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The description of the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The location of the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "location" )]
        public string Location { get; set; }

        /// <summary>
        /// The number of photos in this album
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "size" )]
        public long? Size { get; set; }

        /// <summary>
        /// A link to this album on Facebook
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// Visible only to the album owner. Indicates who can see the album. The value can be one of
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "visible" )]
        public string Visible { get; set; }

        /// <summary>
        /// Indicates the time a major update (like addition of photos) was last made to the album expressed as a unix time.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "modified_major" )]
        public DateTime? ModifiedMajor { get; set; }

        /// <summary>
        /// The URL for editing the album
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "edit_link" )]
        public string EditLink { get; set; }

        /// <summary>
        /// The type of photo album. Can be one of
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// Determines whether a given UID can upload to the album. It is true if the following conditions are met:
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_upload" )]
        public bool? CanUpload { get; set; }

        /// <summary>
        /// The number of photos in the album
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "photo_count" )]
        public long? PhotoCount { get; set; }

        /// <summary>
        /// The number of videos in the album
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "video_count" )]
        public long? VideoCount { get; set; }

        /// <summary>
        /// The like information of the album being queried. This is an object containing can_like, like_count, and user_likes
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "like_info" )]
        public LikeInfo LikeInfo { get; set; }

        /// <summary>
        /// The comment information of the album being queried. This is an object containing can_comment and comment_count
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "comment_info" )]
        public CommentInfo CommentInfo { get; set; }

    }
}
