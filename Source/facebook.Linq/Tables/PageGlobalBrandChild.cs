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
    /// https://developers.facebook.com/docs/reference/fql/page_global_brand_child
    /// </summary>
    [Table(Name = "page_global_brand_child")]
    public class PageGlobalBrandChild
    {
        /// <summary>
        /// ID of the child (local) Page
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "global_brand_child_page_id" , IsPrimaryKey = true)]
        public object GlobalBrandChildPageId { get; set; }

        /// <summary>
        /// ID of the parent (global) Page
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "parent_page_id" )]
        public object ParentPageId { get; set; }

    }
}
