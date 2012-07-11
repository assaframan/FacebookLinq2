using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/domain/
    /// </summary>
    [Table(Name = "domain")]
    public class Domain
    {
        /// <summary>
        /// The domain id.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "domain_id" , IsPrimaryKey = true)]
        public long DomainId { get; set; }

        /// <summary>
        /// The domain name.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "domain_name" )]
        public string DomainName { get; set; }

    }
}
