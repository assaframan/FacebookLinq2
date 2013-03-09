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
    /// https://developers.facebook.com/docs/reference/fql/video
    /// </summary>
    [Table(Name = "video")]
    public class Video
    {
        /// <summary>
        /// The ID of the album where the video belongs to
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "album_id" , IsPrimaryKey = true)]
        public object AlbumId { get; set; }

        /// <summary>
        /// The date when the video being queried was added.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The description of the video being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The HTML code to embed the video.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "embed_html" )]
        public string EmbedHtml { get; set; }

        /// <summary>
        /// The video encoding format. The following are supported: 3g2 (Mobile Video), 3gp (Mobile Video), 3gpp (Mobile Video), asf (Windows Media Video), avi (AVI Video) dat (MPEG Video), divx (DIVX Video), dv (DV Video), f4v (Flash Video), flv (Flash Video), m2ts (M2TS Video), m4v (MPEG-4 Video), mkv (Matroska Format), mod (MOD Video), mov (QuickTime Movie), mp4 (MPEG-4 Video), mpe (MPEG Video), mpeg (MPEG Video), mpeg4 (MPEG-4 Video), mpg (MPEG Video), mts (AVCHD Video), nsv (Nullsoft Video), ogm (Ogg Media Format), ogv (Ogg Video Format), qt (QuickTime Movie), tod (TOD Video), ts (MPEG Transport Stream), vob (DVD Video), wmv (Windows Media Video)
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "format" )]
        public object Format { get; set; }

        /// <summary>
        /// The length of the video in seconds.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "length" )]
        public object Length { get; set; }

        /// <summary>
        /// The URL to the video being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// The user ID of the owner of the video being queried.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

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

        /// <summary>
        /// The URL to the thumbnail image for the video being queried. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thumbnail_link" )]
        public string ThumbnailLink { get; set; }

        /// <summary>
        /// The name of the video being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The date when the video being queried was last modified.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The ID of the video being queried. The vid cannot be longer than 50 characters. Note: Because the vid is a string, you should always wrap the vid in quotes when referenced in a query. The vid is unique only for a given user. You can use the vid as an object ID in the Graph API.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "vid" )]
        public VideoId Vid { get; set; }

    }
}
