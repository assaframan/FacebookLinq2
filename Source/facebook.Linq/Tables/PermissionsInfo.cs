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
    /// http://developers.facebook.com/docs/reference/fql/permissions_info/
    /// </summary>
    [Table(Name = "permissions_info")]
    public class PermissionsInfo
    {
        /// <summary>
        /// The name of the extended permission.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "permission_name" , IsPrimaryKey = true)]
        public string PermissionName { get; set; }

        /// <summary>
        /// A descriptive header for the extended permission.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "header" )]
        public string Header { get; set; }

        /// <summary>
        /// A longer description of the permission.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "summary" )]
        public string Summary { get; set; }

    }
}
