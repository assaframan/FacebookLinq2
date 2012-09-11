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
    /// http://developers.facebook.com/docs/reference/fql/photo/
    /// </summary>
    [Table(Name = "photo")]
    public class Photo
    {
        /// <summary>
        /// The object_id of the photo.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "object_id" , IsPrimaryKey = true)]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// The ID of the photo being queried. The pid cannot be longer than 50 characters.<br /><strong>Note:</strong> Because the pid is a string, you should always wrap the pid in quotes when referenced in a query.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "pid" )]
        public PhotoId Pid { get; set; }

        /// <summary>
        /// The ID of the album containing the photo being queried. The aid cannot be longer than 50 characters.<br /><strong>Note:</strong> Because the aid is a string, you should always wrap the aid in quotes when referenced in a query.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "aid" )]
        public string Aid { get; set; }

        /// <summary>
        /// The user ID of the owner of the photo being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// The URL to the thumbnail version of the photo being queried. The image can have a maximum width of 75px and a maximum height of 225px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src_small" )]
        public string SrcSmall { get; set; }

        /// <summary>
        /// Width of the thumbnail version, in px. This field may be blank.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "src_small_width" )]
        public long? SrcSmallWidth { get; set; }

        /// <summary>
        /// Height of the thumbnail version, in px. This field may be blank.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "src_small_height" )]
        public long? SrcSmallHeight { get; set; }

        /// <summary>
        /// The URL to the full-sized version of the photo being queried. The image can have a maximum width or height of 720px, <a href='/blog/post/602/'>increasing to 960px</a> on 1st March 2012. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src_big" )]
        public string SrcBig { get; set; }

        /// <summary>
        /// Width of the full-sized version, in px. This field may be blank.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "src_big_width" )]
        public long? SrcBigWidth { get; set; }

        /// <summary>
        /// Height of the full-sized version, in px. This field may be blank.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "src_big_height" )]
        public long? SrcBigHeight { get; set; }

        /// <summary>
        /// The URL to the album view version of the photo being queried. The image can have a maximum width or height of 130px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src" )]
        public string Src { get; set; }

        /// <summary>
        /// Width of the album view version, in px. This field may be blank.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "src_width" )]
        public long? SrcWidth { get; set; }

        /// <summary>
        /// Height of the album view version, in px. This field may be blank.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "src_height" )]
        public long? SrcHeight { get; set; }

        /// <summary>
        /// The URL to the page containing the photo being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// The caption for the photo being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "caption" )]
        public string Caption { get; set; }

        /// <summary>
        /// An array containing an array of objects mentioned in the caption which contain the id, name, and type of each object as well as the offset and length which can be used to match it up with its corresponding string in the caption.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "caption_tags" )]
        public JsonObject CaptionTags { get; set; }

        /// <summary>
        /// The date when the photo being queried was added.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created" )]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date when the photo being queried was last modified.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "modified" )]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The position of the photo in the album.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "position" )]
        public long? Position { get; set; }

        /// <summary>
        /// The object_id of the album the photo belongs to.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "album_object_id" )]
        public long? AlbumObjectId { get; set; }

        /// <summary>
        /// Facebook ID of the place associated with the photo, if any.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "place_id" )]
        public long? PlaceId { get; set; }

        /// <summary>
        /// An array of objects containing width, height, source each representing the various photo sizes.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "images" )]
        public JsonObject Images { get; set; }

        /// <summary>
        /// The like information of the photo being queried. This is an object containing can_like, like_count, and user_likes
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "like_info" )]
        public LikeInfo LikeInfo { get; set; }

        /// <summary>
        /// The comment information of the photo being queried. This is an object containing can_comment and comment_count
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "comment_info" )]
        public CommentInfo CommentInfo { get; set; }

        /// <summary>
        /// true if the viewer is able to delete the photo
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_delete" )]
        public bool? CanDelete { get; set; }

    }
}
