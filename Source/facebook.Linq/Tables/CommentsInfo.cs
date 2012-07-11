using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/comments_info/
    /// </summary>
    [Table(Name = "comments_info")]
    public class CommentsInfo
    {
        /// <summary>
        /// The application ID. You can specify more than one application ID.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "app_id" , IsPrimaryKey = true)]
        public string AppId { get; set; }

        /// <summary>
        /// The [XID|external ID] of the <a href="/docs/reference/fbml/comments">fb:comments</a> object being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "xid" )]
        public string Xid { get; set; }

        /// <summary>
        /// The number of comments associated with an XID.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "count" )]
        public long Count { get; set; }

        /// <summary>
        /// A Unix timestamp indicating the most recent time a comment was made.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "updated_time" )]
        public long UpdatedTime { get; set; }

    }
}
