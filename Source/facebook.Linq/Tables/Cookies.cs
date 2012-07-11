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
    /// http://developers.facebook.com/docs/reference/fql/cookies/
    /// </summary>
    [Table(Name = "cookies")]
    public class Cookies
    {
        /// <summary>
        /// The user ID associated with the cookie.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public string Uid { get; set; }

        /// <summary>
        /// The name of the cookie.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The value of the cookie.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "value" )]
        public string Value { get; set; }

        /// <summary>
        /// Time stamp when the cookie should expire. If not specified, the cookie never expires.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "expires" )]
        public long? Expires { get; set; }

        /// <summary>
        /// Path relative to the application's callback URL, with which the cookie should be associated. Default value is /
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "path" )]
        public string Path { get; set; }

    }
}
