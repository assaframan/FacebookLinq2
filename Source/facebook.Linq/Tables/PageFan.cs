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
    /// http://developers.facebook.com/docs/reference/fql/page_fan/
    /// </summary>
    [Table(Name = "page_fan")]
    public class PageFan
    {
        /// <summary>
        /// The ID of the Page being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_id" )]
        public string PageId { get; set; }

        /// <summary>
        /// The type of Page being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The profile section the Page is in on the user's profile..
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_section" )]
        public string ProfileSection { get; set; }

        /// <summary>
        /// The unix time when the user liked this Page
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime CreatedTime { get; set; }

    }
}
