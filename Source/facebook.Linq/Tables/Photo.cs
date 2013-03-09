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
    /// https://developers.facebook.com/docs/reference/fql/photo
    /// </summary>
    [Table(Name = "photo")]
    public class Photo
    {
        /// <summary>
        /// The ID of the album containing the photo being queried. The aid cannot be longer than 50 characters. Note: Because the aid is a string, you should always wrap the aid in quotes when referenced in a query.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "aid" , IsPrimaryKey = true)]
        public AlbumId Aid { get; set; }

        /// <summary>
        /// A cursor used to paginated through a query that is indexed on the aid
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "aid_cursor" )]
        public string AidCursor { get; set; }

        /// <summary>
        /// The object_id of the album the photo belongs to.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "album_object_id" )]
        public ObjectId AlbumObjectId { get; set; }

        /// <summary>
        /// A cursor used to paginate through a query that is indexed on the album_object_id
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "album_object_id_cursor" )]
        public string AlbumObjectIdCursor { get; set; }

        /// <summary>
        /// The time the photo was backdated to in Timeline
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "backdated_time" )]
        public DateTime? BackdatedTime { get; set; }

        /// <summary>
        /// A string representing the backdated granularity. Valid values are year, month, day, hour, or minute
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "backdated_time_granularity" )]
        public string BackdatedTimeGranularity { get; set; }

        /// <summary>
        /// true if the viewer is able to backdate the photo
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_backdate" )]
        public bool? CanBackdate { get; set; }

        /// <summary>
        /// true if the viewer is able to delete the photo
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_delete" )]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// true if the viewer is able to tag the photo
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_tag" )]
        public bool? CanTag { get; set; }

        /// <summary>
        /// The caption for the photo being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "caption" )]
        public string Caption { get; set; }

        /// <summary>
        /// An array indexed by offset of arrays of the tags in the caption of the photo, containing the id of the tagged object, the name of the tag, the offset of where the tag occurs in the message and the length of the tag.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "caption_tags" )]
        public object CaptionTags { get; set; }

        /// <summary>
        /// The comment information of the photo being queried. This is an object containing can_comment and comment_count
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "comment_info" )]
        public CommentInfo CommentInfo { get; set; }

        /// <summary>
        /// The date when the photo being queried was added.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created" )]
        public object Created { get; set; }

        /// <summary>
        /// An array of objects containing width, height, source each representing the various photo sizes.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "images" )]
        public object Images { get; set; }

        /// <summary>
        /// The like information of the photo being queried. This is an object containing can_like, like_count, and user_likes
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "like_info" )]
        public LikeInfo LikeInfo { get; set; }

        /// <summary>
        /// The URL to the page containing the photo being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// The date when the photo being queried was last modified.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "modified" )]
        public object Modified { get; set; }

        /// <summary>
        /// The object_id of the photo.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "object_id" )]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// The offline_id is specificed when uploading a photo to track the upload status of it later
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "offline_id" )]
        public object OfflineId { get; set; }

        /// <summary>
        /// The user ID of the owner of the photo being queried.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// A cursor used to paginate through a query that is indexed on the owner
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "owner_cursor" )]
        public string OwnerCursor { get; set; }

        /// <summary>
        /// The ID of the feed story about this photo if itbelongs to a page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_story_id" )]
        public string PageStoryId { get; set; }

        /// <summary>
        /// The ID of the photo being queried. The pid cannot be longer than 50 characters. Note: Because the pid is a string, you should always wrap the pid in quotes when referenced in a query.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pid" )]
        public PhotoId Pid { get; set; }

        /// <summary>
        /// Facebook ID of the place associated with the photo, if any.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "place_id" )]
        public object PlaceId { get; set; }

        /// <summary>
        /// The position of the photo in the album.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "position" )]
        public object Position { get; set; }

        /// <summary>
        /// The URL to the album view version of the photo being queried. The image can have a maximum width or height of 130px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src" )]
        public string Src { get; set; }

        /// <summary>
        /// The URL to the full-sized version of the photo being queried. The image can have a maximum width or height of 720px, <a href='/blog/post/602/'>increasing to 960px</a> on 1st March 2012. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src_big" )]
        public string SrcBig { get; set; }

        /// <summary>
        /// Height of the full-sized version, in px. This field may be blank.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "src_big_height" )]
        public object SrcBigHeight { get; set; }

        /// <summary>
        /// Width of the full-sized version, in px. This field may be blank.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "src_big_width" )]
        public object SrcBigWidth { get; set; }

        /// <summary>
        /// Height of the album view version, in px. This field may be blank.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "src_height" )]
        public object SrcHeight { get; set; }

        /// <summary>
        /// The URL to the thumbnail version of the photo being queried. The image can have a maximum width of 75px and a maximum height of 225px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src_small" )]
        public string SrcSmall { get; set; }

        /// <summary>
        /// Height of the thumbnail version, in px. This field may be blank.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "src_small_height" )]
        public object SrcSmallHeight { get; set; }

        /// <summary>
        /// Width of the thumbnail version, in px. This field may be blank.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "src_small_width" )]
        public object SrcSmallWidth { get; set; }

        /// <summary>
        /// Width of the album view version, in px. This field may be blank.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "src_width" )]
        public object SrcWidth { get; set; }

        /// <summary>
        /// The ID of the target the photo is posted to
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "target_id" )]
        public UnionId TargetId { get; set; }

        /// <summary>
        /// The type of target the photo is posted to
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "target_type" )]
        public string TargetType { get; set; }

    }
}
