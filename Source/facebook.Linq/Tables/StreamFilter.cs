using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/stream_filter/
    /// </summary>
    [Table(Name = "stream_filter")]
    public class StreamFilter
    {
        /// <summary>
        /// The ID of the user whose filters you are querying.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public string Uid { get; set; }

        /// <summary>
        /// A key identifying a particular filter for a user's stream. This filter is useful to retrieve relevant items from the stream table.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "filter_key " )]
        public string FilterKey { get; set; }

        /// <summary>
        /// The name of the filter as it appears on the home page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// A 32-bit int that indicates where the filter appears in the sort.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "rank " )]
        public long Rank { get; set; }

        /// <summary>
        /// The URL to the filter icon. For applications, this is the same as your application icon.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon_url" )]
        public string IconUrl { get; set; }

        /// <summary>
        /// If true, indicates that the filter is visible on the home page. If false, the filter is hidden in the <b>More</b> link.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_visible" )]
        public string IsVisible { get; set; }

        /// <summary>
        /// The type of filter. One of <code>application</code>, <code>newsfeed</code>, <code>friendlist</code>, <code>network</code>, or <code>public_profiles</code>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// A 64-bit ID for the filter type.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "value" )]
        public long Value { get; set; }

    }
}
