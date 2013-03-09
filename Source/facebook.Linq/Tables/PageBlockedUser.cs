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
    /// https://developers.facebook.com/docs/reference/fql/page_blocked_user
    /// </summary>
    [Table(Name = "page_blocked_user")]
    public class PageBlockedUser
    {
        /// <summary>
        /// The ID of the Page
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "page_id" , IsPrimaryKey = true)]
        public PageId PageId { get; set; }

        /// <summary>
        /// The ID of any user blocked by the Page
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "uid" )]
        public object Uid { get; set; }

    }
}
