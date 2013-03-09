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
    /// https://developers.facebook.com/docs/reference/fql/stream_filter
    /// </summary>
    [Table(Name = "stream_filter")]
    public class StreamFilter
    {
        /// <summary>
        /// A key identifying a particular filter for a user's stream
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "filter_key" , IsPrimaryKey = true)]
        public string FilterKey { get; set; }

        /// <summary>
        /// The URL to the filter icon. For applications, this is the same as the application's icon
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon_url" )]
        public string IconUrl { get; set; }

        /// <summary>
        /// If true, indicates that the filter is visible on the home page. If false, the filter is hidden in the <strong>More</strong> link
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_visible" )]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// The name of the filter as it appears on the home page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The rank of where the filter appears in sort on News Feed
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "rank" )]
        public object Rank { get; set; }

        /// <summary>
        /// The type of filter. One of application, newsfeed, friendlist, network, or public_profiles
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the user whose filters you are querying
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

        /// <summary>
        /// ID for the filter type
        /// 
        /// original type is: (number) or (string)
        /// </summary>
        [Column(Name = "value" )]
        public object Value { get; set; }

    }
}
