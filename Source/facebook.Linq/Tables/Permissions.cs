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
    /// https://developers.facebook.com/docs/reference/fql/permissions
    /// </summary>
    [Table(Name = "permissions")]
    public class Permissions
    {
        /// <summary>
        /// Provides access to read if your app has been bookmarked
        /// 
        /// original type is: number (min: 0) (max: 1)
        /// </summary>
        [Column(Name = "bookmarked" , IsPrimaryKey = true)]
        public object Bookmarked { get; set; }

        /// <summary>
        /// Provides access to read if your app has been added as a tab
        /// 
        /// original type is: number (min: 0) (max: 1)
        /// </summary>
        [Column(Name = "tab_added" )]
        public object TabAdded { get; set; }

        /// <summary>
        /// The user ID of the current user, or the ID of the page
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

    }
}
