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
    /// https://developers.facebook.com/docs/reference/fql/link
    /// </summary>
    [Table(Name = "link")]
    public class Link
    {
        /// <summary>
        /// Time that the link is backdated to.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "backdated_time" , IsPrimaryKey = true)]
        public DateTime? BackdatedTime { get; set; }

        /// <summary>
        /// Can the link be backdated on Timeline.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_backdate" )]
        public bool? CanBackdate { get; set; }

        /// <summary>
        /// The caption of the link.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "caption" )]
        public string Caption { get; set; }

        /// <summary>
        /// The comment information of the link being queried. This is an object containing can_comment and comment_count.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "comment_info" )]
        public CommentInfo CommentInfo { get; set; }

        /// <summary>
        /// The time the user posted the link.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The URLs to the images associated with the link, as taken from the site's link tag.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "image_urls" )]
        public Urls ImageUrls { get; set; }

        /// <summary>
        /// The like information of the link being queried. This is an object containing can_like, like_count, and user_likes.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "like_info" )]
        public LikeInfo LikeInfo { get; set; }

        /// <summary>
        /// The unique identifier for the link.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "link_id" )]
        public LinkId LinkId { get; set; }

        /// <summary>
        /// The user ID for the user who posted the link.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// The comment the owner made about the link.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "owner_comment" )]
        public string OwnerComment { get; set; }

        /// <summary>
        /// Cursor for the owner field.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "owner_cursor" )]
        public string OwnerCursor { get; set; }

        /// <summary>
        /// The URL to the thumbnail image that is displayed by default
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "picture" )]
        public string Picture { get; set; }

        /// <summary>
        /// The privacy setting of the link being queried.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "privacy" )]
        public object Privacy { get; set; }

        /// <summary>
        /// A summary of the link, as taken from the site's description meta tag.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "summary" )]
        public string Summary { get; set; }

        /// <summary>
        /// The title of the link, as taken from the site's title meta tag.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The actual URL for the link.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" )]
        public string Url { get; set; }

        /// <summary>
        /// The unique identifier of the original link poster.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "via_id" )]
        public object ViaId { get; set; }

    }
}
