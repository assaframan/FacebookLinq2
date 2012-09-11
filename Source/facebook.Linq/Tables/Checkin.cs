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
    /// http://developers.facebook.com/docs/reference/fql/checkin/
    /// </summary>
    [Table(Name = "checkin")]
    public class Checkin
    {
        /// <summary>
        /// The ID of the check-in.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "checkin_id" , IsPrimaryKey = true)]
        public CheckinId CheckinId { get; set; }

        /// <summary>
        /// The ID of the user making the checkin.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "author_uid" )]
        public Uid AuthorUid { get; set; }

        /// <summary>
        /// The ID of the Page representing the place.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// The ID of an app that made the checkin.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "app_id" )]
        public AppId AppId { get; set; }

        /// <summary>
        /// The ID of the stream post created by the check-in
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "post_id" )]
        public PostId PostId { get; set; }

        /// <summary>
        /// The latitude and longitude of the location.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "coords" )]
        public Coords Coords { get; set; }

        /// <summary>
        /// A Unix timestamp of the checkin.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "timestamp" )]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The IDs of users tagged in the checkin.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tagged_uids" )]
        public UidsList TaggedUids { get; set; }

        /// <summary>
        /// The message the author posted with the checkin.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

    }
}
