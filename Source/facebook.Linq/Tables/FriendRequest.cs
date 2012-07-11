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
    /// http://developers.facebook.com/docs/reference/fql/friend_request/
    /// </summary>
    [Table(Name = "friend_request")]
    public class FriendRequest
    {
        /// <summary>
        /// The ID of the user receiving the friend request.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid_to" , IsPrimaryKey = true)]
        public string UidTo { get; set; }

        /// <summary>
        /// The ID of the user making the friend request.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid_from" )]
        public string UidFrom { get; set; }

        /// <summary>
        /// A unix timestamp indicating when the friend request was sent.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "time" )]
        public DateTime Time { get; set; }

        /// <summary>
        /// An optional message sent by the user with the friend request.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// Returns true if the user has not yet seen the friend request. Only available if the <strong>uid_to</strong> parameter is set to the logged-in user
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "unread" )]
        public bool Unread { get; set; }

    }
}
