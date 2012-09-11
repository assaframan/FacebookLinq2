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
    /// http://developers.facebook.com/docs/reference/fql/links/
    /// </summary>
    [Table(Name = "link")]
    public class Link
    {
        /// <summary>
        /// The unique identifier for the link.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link_id" , IsPrimaryKey = true)]
        public LinkId LinkId { get; set; }

        /// <summary>
        /// The user ID for the user who posted the link.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// The comment the owner made about the link.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "owner_comment" )]
        public string OwnerComment { get; set; }

        /// <summary>
        /// The time the user posted the link.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The title of the link, as taken from the site's title meta tag.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// A summary of the link, as taken from the site's description meta tag.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "summary" )]
        public string Summary { get; set; }

        /// <summary>
        /// The actual URL for the link.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" )]
        public string Url { get; set; }

        /// <summary>
        /// The URL to the thumbnail image that is displayed by default
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "picture" )]
        public string Picture { get; set; }

        /// <summary>
        /// The URLs to the images associated with the link, as taken from the site's link tag.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "image_urls" )]
        public UrlList ImageUrls { get; set; }

    }
}
