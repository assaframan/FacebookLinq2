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
    /// http://developers.facebook.com/docs/reference/fql/url_like/
    /// </summary>
    [Table(Name = "url_like")]
    public class UrlLike
    {
        /// <summary>
        /// The ID of the user who has liked the URL
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "user_id" , IsPrimaryKey = true)]
        public Uid UserId { get; set; }

        /// <summary>
        /// The URL that was liked
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" )]
        public string Url { get; set; }

    }
}
