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
    /// http://developers.facebook.com/docs/reference/fql/object_url/
    /// </summary>
    [Table(Name = "object_url")]
    public class ObjectUrl
    {
        /// <summary>
        /// The URL for the webpage being queried
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" , IsPrimaryKey = true)]
        public string Url { get; set; }

        /// <summary>
        /// The ID of the Graph object represented by the URL
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "id" )]
        public long? Id { get; set; }

        /// <summary>
        /// The type of object the URL represents (note: 'Page' incorporates any URL with an 'og:type' specified)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The normalized domain name the URL is on
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "site" )]
        public string Site { get; set; }

    }
}
