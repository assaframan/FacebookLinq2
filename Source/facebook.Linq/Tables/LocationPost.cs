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
    /// https://developers.facebook.com/docs/reference/fql/location_post
    /// </summary>
    [Table(Name = "location_post")]
    public class LocationPost
    {
        /// <summary>
        /// ID of the application that published the post
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "app_id" , IsPrimaryKey = true)]
        public AppId AppId { get; set; }

        /// <summary>
        /// ID of person publishing the post
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "author_uid" )]
        public object AuthorUid { get; set; }

        /// <summary>
        /// Coordinates of the checkin location
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "coords" )]
        public Coords Coords { get; set; }

        /// <summary>
        /// ID of the object associated with this location
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "id" )]
        public ObjectId Id { get; set; }

        /// <summary>
        /// Latitude of the checkin location
        /// 
        /// original type is: float
        /// </summary>
        [Column(Name = "latitude" )]
        public float? Latitude { get; set; }

        /// <summary>
        /// Longitude of the checkin location
        /// 
        /// original type is: float
        /// </summary>
        [Column(Name = "longitude" )]
        public float? Longitude { get; set; }

        /// <summary>
        /// Message of the post story
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// ID of the Facebook page associated with the location or event in the post
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// Type of the target. For example, page and event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_type" )]
        public string PageType { get; set; }

        /// <summary>
        /// ID of the post story
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "post_id" )]
        public PostId PostId { get; set; }

        /// <summary>
        /// IDs of users tagged in the checkin
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tagged_uids" )]
        public UidsList TaggedUids { get; set; }

        /// <summary>
        /// UNIX timestamp of the checkin
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "timestamp" )]
        public object Timestamp { get; set; }

        /// <summary>
        /// The type of post. Either photo, checkin, video, or status
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

    }
}
