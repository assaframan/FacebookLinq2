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
    /// http://developers.facebook.com/docs/reference/fql/domain_admin/
    /// </summary>
    [Table(Name = "domain_admin")]
    public class DomainAdmin
    {
        /// <summary>
        /// The ID of the profile who owns the domain.  This can be a page, application, or user ID.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "owner_id" , IsPrimaryKey = true)]
        public Uid OwnerId { get; set; }

        /// <summary>
        /// The ID of the domain being queried.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "domain_id" )]
        public DomainId DomainId { get; set; }

    }
}
