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
    /// https://developers.facebook.com/docs/reference/fql/video_tag
    /// </summary>
    [Table(Name = "video_tag")]
    public class VideoTag
    {
        /// <summary>
        /// The date when the video being queried was added.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "created_time" , IsPrimaryKey = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// For tagged users, use the user ID of the subject for the tag being queried. For videos associated with events or groups, use the event ID or group ID for subject.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "subject" )]
        public Uid Subject { get; set; }

        /// <summary>
        /// The date when the video being queried was last modified.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The ID of the video being queried. The vid cannot be longer than 50 characters. Note: Because the vid is a string, you should always wrap the vid in quotes when referenced in a query.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "vid" )]
        public VideoId Vid { get; set; }

    }
}
