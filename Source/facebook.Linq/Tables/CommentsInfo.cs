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
    /// https://developers.facebook.com/docs/reference/fql/comments_info
    /// </summary>
    [Table(Name = "comments_info")]
    public class CommentsInfo
    {
        /// <summary>
        /// The application ID. You can specify more than one application ID.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "app_id" , IsPrimaryKey = true)]
        public AppId AppId { get; set; }

        /// <summary>
        /// The number of comments associated with an XID.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "count" )]
        public object Count { get; set; }

        /// <summary>
        /// A UNIX timestamp indicating the most recent time a comment was made.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The [XID|external ID] of the <a href="/docs/reference/fbml/comments">fb:comments</a> objects being queried
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "xid" )]
        public Xid Xid { get; set; }

    }
}
