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
    /// http://developers.facebook.com/docs/reference/fql/video/
    /// </summary>
    [Table(Name = "video")]
    public class Video
    {
        /// <summary>
        /// The ID of the video being queried. The vid cannot be longer than 50 characters.<br /><strong>Note:</strong> Because the vid is a string, you should always wrap the vid in quotes when referenced in a query. The vid is unique only for a given user. You can use the vid as an object ID in the Graph API.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "vid" , IsPrimaryKey = true)]
        public VideoId Vid { get; set; }

        /// <summary>
        /// The user ID of the owner of the video being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// The name of the video being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The description of the video being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The URL to the video being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// The URL to the thumbnail image for the video being queried. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thumbnail_link" )]
        public string ThumbnailLink { get; set; }

        /// <summary>
        /// The HTML code to embed the video.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "embed_html" )]
        public string EmbedHtml { get; set; }

        /// <summary>
        /// The date when the video being queried was last modified.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The date when the video being queried was added.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The length of the video in seconds.
        /// 
        /// original type is: float
        /// </summary>
        [Column(Name = "length" )]
        public float? Length { get; set; }

        /// <summary>
        /// The URL to thesource file for the standard quality version of the video.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src" )]
        public string Src { get; set; }

        /// <summary>
        /// The URL to the source file for the high quality version of the video.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src_hq" )]
        public string SrcHq { get; set; }

    }
}
