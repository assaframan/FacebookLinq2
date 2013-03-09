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
    /// https://developers.facebook.com/docs/reference/fql/app_role
    /// </summary>
    [Table(Name = "app_role")]
    public class AppRole
    {
        /// <summary>
        /// The application ID
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "application_id" , IsPrimaryKey = true)]
        public object ApplicationId { get; set; }

        /// <summary>
        /// The user ID
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "developer_id" )]
        public Uid DeveloperId { get; set; }

        /// <summary>
        /// The role that the user has for this application, one of: administrators, developers, testers, insights users
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "role" )]
        public string Role { get; set; }

    }
}
