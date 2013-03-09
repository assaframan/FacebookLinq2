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
    /// https://developers.facebook.com/docs/reference/fql/page_admin
    /// </summary>
    [Table(Name = "page_admin")]
    public class PageAdmin
    {
        /// <summary>
        /// The UNIX timestamp of the last time the admin used this page
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "last_used_time" , IsPrimaryKey = true)]
        public DateTime? LastUsedTime { get; set; }

        /// <summary>
        /// The ID of a Page
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// Admin's permission levels for this page
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "perms" )]
        public object Perms { get; set; }

        /// <summary>
        /// Admin's role types for this page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "role" )]
        public string Role { get; set; }

        /// <summary>
        /// The type of the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The User ID of an admin of a Page
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

    }
}
