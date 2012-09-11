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
    /// http://developers.facebook.com/docs/reference/fql/permissions/
    /// </summary>
    [Table(Name = "permissions")]
    public class Permissions
    {
        /// <summary>
        /// The user ID of the current user, or the ID of the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public Uid Uid { get; set; }

        /// <summary>
        /// Indicates whether the user granted your app a specific permission. Substitute the name of a specific <a href="/docs/authentication/permissions">permission</a> for PERMISSION_NAME.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "PERMISSION_NAME" )]
        public bool? PERMISSIONNAME { get; set; }

    }
}
