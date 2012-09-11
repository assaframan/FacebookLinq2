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
    /// http://developers.facebook.com/docs/reference/fql/subscription/
    /// </summary>
    [Table(Name = "subscription")]
    public class Subscription
    {
        /// <summary>
        /// The user ID of the subscribed-to user in a particular subscription link.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "subscribed_id" , IsPrimaryKey = true)]
        public Uid SubscribedId { get; set; }

        /// <summary>
        /// The user ID of the subscribing user in a particular subscription link.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "subscriber_id" )]
        public Uid SubscriberId { get; set; }

    }
}
