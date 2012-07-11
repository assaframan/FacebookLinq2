using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/subscription/
    /// </summary>
    [Table(Name = "subscription")]
    public class Subscription
    {
        /// <summary>
        /// The <code>user</code> ID of the subscribed-to <code>user</code> in a particular subscription link.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "subscribed_id" , IsPrimaryKey = true)]
        public long SubscribedId { get; set; }

        /// <summary>
        /// The <code>user</code> ID of the subscribing <code>user</code> in a particular subscription link.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "subscriber_id" )]
        public long SubscriberId { get; set; }

    }
}
