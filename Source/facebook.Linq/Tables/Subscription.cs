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
    /// https://developers.facebook.com/docs/reference/fql/subscription
    /// </summary>
    [Table(Name = "subscription")]
    public class Subscription
    {
        /// <summary>
        /// The user ID of the subscribed-to user in a particular subscription link
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "subscribed_id" , IsPrimaryKey = true)]
        public Uid SubscribedId { get; set; }

        /// <summary>
        /// A cursor used to paginate through a query indexed on the subscribed_id
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subscribed_id_cursor" )]
        public string SubscribedIdCursor { get; set; }

        /// <summary>
        /// The user ID of the subscribing user in a particular subscription link
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "subscriber_id" )]
        public Uid SubscriberId { get; set; }

        /// <summary>
        /// A cursor used to paginate through a query indexed on the subscriber_id
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subscriber_id_cursor" )]
        public string SubscriberIdCursor { get; set; }

    }
}
