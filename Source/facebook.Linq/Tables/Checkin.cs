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
    /// https://developers.facebook.com/docs/reference/fql/checkin
    /// </summary>
    [Table(Name = "checkin")]
    public class Checkin
    {
        /// <summary>
        /// The ID of an app that made the checkin.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "app_id" , IsPrimaryKey = true)]
        public AppId AppId { get; set; }

        /// <summary>
        /// The ID of the user making the checkin.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "author_uid" )]
        public Uid AuthorUid { get; set; }

        /// <summary>
        /// The ID of the check-in.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "checkin_id" )]
        public CheckinId CheckinId { get; set; }

        /// <summary>
        /// The latitude and longitude of the location.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "coords" )]
        public Coords Coords { get; set; }

        /// <summary>
        /// The message the author posted with the checkin.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the stream post created by the check-in
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "post_id" )]
        public PostId PostId { get; set; }

        /// <summary>
        /// The IDs of users tagged in the checkin.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tagged_uids" )]
        public UidsList TaggedUids { get; set; }

        /// <summary>
        /// The ID of Event or Page the user is checking into.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "target_id" )]
        public UnionId TargetId { get; set; }

        /// <summary>
        /// The type of the target for the checkin. This can beevent or page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "target_type" )]
        public string TargetType { get; set; }

        /// <summary>
        /// A UNIX timestamp of the checkin.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "timestamp" )]
        public object Timestamp { get; set; }

    }
}
