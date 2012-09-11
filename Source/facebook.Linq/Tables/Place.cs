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
    /// http://developers.facebook.com/docs/reference/fql/place/
    /// </summary>
    [Table(Name = "place")]
    public class Place
    {
        /// <summary>
        /// The Facebook Page ID of the place
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "page_id" , IsPrimaryKey = true)]
        public PageId PageId { get; set; }

        /// <summary>
        /// The name of the place.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The description of the place.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// An array describing where the location exists, in GeoJSON format. (This could be a point, a polygon, or other types of geometries.)
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "geometry" )]
        public object Geometry { get; set; }

        /// <summary>
        /// The latitude of the location.
        /// 
        /// original type is: float
        /// </summary>
        [Column(Name = "latitude" )]
        public float? Latitude { get; set; }

        /// <summary>
        /// The longitude of the location.
        /// 
        /// original type is: float
        /// </summary>
        [Column(Name = "longitude" )]
        public float? Longitude { get; set; }

        /// <summary>
        /// The number of times users have checked into the location.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "checkin_count" )]
        public long? CheckinCount { get; set; }

        /// <summary>
        /// Display text containing metadata about the location.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "display_subtext" )]
        public string DisplaySubtext { get; set; }

    }
}
