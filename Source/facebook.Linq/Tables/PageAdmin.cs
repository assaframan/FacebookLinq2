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
    /// http://developers.facebook.com/docs/reference/fql/page_admin/
    /// </summary>
    [Table(Name = "page_admin")]
    public class PageAdmin
    {
        /// <summary>
        /// The User ID of an admin of a Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public Uid Uid { get; set; }

        /// <summary>
        /// The ID of a Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// The type of the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

    }
}
