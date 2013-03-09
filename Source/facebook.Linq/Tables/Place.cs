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
    /// https://developers.facebook.com/docs/reference/fql/place
    /// </summary>
    [Table(Name = "place")]
    public class Place
    {
        /// <summary>
        /// The number of times users have checked into the location.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "checkin_count" , IsPrimaryKey = true)]
        public object CheckinCount { get; set; }

        /// <summary>
        /// Time when the post was created or -1 if unknown
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "content_age" )]
        public object ContentAge { get; set; }

        /// <summary>
        /// The description of the place.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// Display text containing metadata about the location.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "display_subtext" )]
        public string DisplaySubtext { get; set; }

        /// <summary>
        /// Description of the geometry of the location being queries
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "geometry" )]
        public object Geometry { get; set; }

        /// <summary>
        /// Boolean describing if this location is a city
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_city" )]
        public bool? IsCity { get; set; }

        /// <summary>
        /// Boolean flag indicating if this page is unclaimed or not
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_unclaimed" )]
        public bool? IsUnclaimed { get; set; }

        /// <summary>
        /// The latitude of the location.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "latitude" )]
        public object Latitude { get; set; }

        /// <summary>
        /// The longitude of the location.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "longitude" )]
        public object Longitude { get; set; }

        /// <summary>
        /// The name of the place.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The Facebook Page ID of the place
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// Profile picture of the place. Scales to 100 pixels
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// Profile picture of the place. Scales to 200 pixels
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// Profile picture of the place, cropped to the specified dimensions
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "pic_crop" )]
        public object PicCrop { get; set; }

        /// <summary>
        /// Profile picture of the place. Scales to 396 pixels
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_large" )]
        public string PicLarge { get; set; }

        /// <summary>
        /// Profile picture of the place. Scales to 50 pixels
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// Profile 50x50 pixels picture of the place.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// Enum describing the search mode available to query for a location. Can be: graph_no_radius, mobile_checkin, mobile_status, mobile_photo, mobile_album, mobile_video, and mobile_event.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "search_type" )]
        public string SearchType { get; set; }

        /// <summary>
        /// Enum describing the type of location this place is. Can be PLACE, CITY, STATE_PROVINCE, COUNTRY, EVENT, UNCONFIRMED_RESIDENCE, RESIDENCE, TEXT.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

    }
}
