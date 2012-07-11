using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/video_tag/
    /// </summary>
    [Table(Name = "video_tag")]
    public class VideoTag
    {
        /// <summary>
        /// The ID of the video being queried. The <code>vid</code> cannot be longer than 50 characters.<br /><strong>Note:</strong> Because the vid is a string, you should always wrap the vid in quotes when referenced in a query.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "vid" , IsPrimaryKey = true)]
        public string Vid { get; set; }

        /// <summary>
        /// For tagged users, use the user ID of the subject for the tag being queried. For videos associated with events or groups, use the event ID or group ID for subject.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "subject" )]
        public long Subject { get; set; }

        /// <summary>
        /// The date when the video being queried was last modified.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime UpdatedTime { get; set; }

        /// <summary>
        /// The date when the video being queried was added.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime CreatedTime { get; set; }

    }
}
