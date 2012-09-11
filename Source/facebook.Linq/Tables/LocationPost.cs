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
    /// http://developers.facebook.com/docs/reference/fql/location_post/
    /// </summary>
    [Table(Name = "location_post")]
    public class LocationPost
    {
        /// <summary>
        /// ID of the object associated with this location
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public long? Id { get; set; }

        /// <summary>
        /// ID of person publishing the post
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "author_uid" )]
        public Uid AuthorUid { get; set; }

        /// <summary>
        /// ID of application that published the post
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "app_id" )]
        public AppId AppId { get; set; }

        /// <summary>
        /// UNIX timestamp
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "timestamp" )]
        public long? Timestamp { get; set; }

        /// <summary>
        /// array of ints representing the Facebook IDs tagged in the post
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tagged_uids" )]
        public UidsList TaggedUids { get; set; }

        /// <summary>
        /// ID of the Facebook page associated with the location or event in the post
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// Type of the target; either page or event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_type" )]
        public string PageType { get; set; }

        /// <summary>
        /// object with latitude and longitude fields
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "coords" )]
        public JsonObject Coords { get; set; }

        /// <summary>
        /// The type of post. Either photo, checkin, video, or status
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

    }
}
