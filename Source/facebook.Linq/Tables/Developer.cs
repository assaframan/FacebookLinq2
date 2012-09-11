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
    /// http://developers.facebook.com/docs/reference/fql/developer/
    /// </summary>
    [Table(Name = "developer")]
    public class Developer
    {
        /// <summary>
        /// The user ID.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "developer_id" , IsPrimaryKey = true)]
        public Uid DeveloperId { get; set; }

        /// <summary>
        /// The application ID.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "application_id" )]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The role that the user has for this application, one of:
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "role" )]
        public string Role { get; set; }

    }
}
