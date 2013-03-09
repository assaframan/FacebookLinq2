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
    /// https://developers.facebook.com/docs/reference/fql/link_image_src
    /// </summary>
    [Table(Name = "link_image_src")]
    public class LinkImageSrc
    {
        /// <summary>
        /// The maximum height of the resized image.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "max_height" , IsPrimaryKey = true)]
        public object MaxHeight { get; set; }

        /// <summary>
        /// The maximum width of the resized image.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "max_width" )]
        public object MaxWidth { get; set; }

        /// <summary>
        /// The source URL to be proxied. This must already be a proxied URL.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "source_url" )]
        public string SourceUrl { get; set; }

        /// <summary>
        /// The proxied URL given a source URL, maximum height, and maximum width.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" )]
        public string Url { get; set; }

    }
}
