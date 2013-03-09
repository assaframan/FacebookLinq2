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
    /// https://developers.facebook.com/docs/reference/fql/page_fan
    /// </summary>
    [Table(Name = "page_fan")]
    public class PageFan
    {
        /// <summary>
        /// The UNIX time when the user liked the Page.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "created_time" , IsPrimaryKey = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The ID of the Page being queried.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// The profile section on the user's profile which contains the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_section" )]
        public string ProfileSection { get; set; }

        /// <summary>
        /// The type of Page being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The user ID who has liked the Page being queried.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

    }
}
