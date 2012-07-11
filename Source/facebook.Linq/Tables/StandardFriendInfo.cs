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
    /// http://developers.facebook.com/docs/reference/fql/standard_friend_info/
    /// </summary>
    [Table(Name = "standard_friend_info")]
    public class StandardFriendInfo
    {
        /// <summary>
        /// The user ID of the first user in the pair being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "uid1" , IsPrimaryKey = true)]
        public long? Uid1 { get; set; }

        /// <summary>
        /// The user ID of the second user in the pair being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "uid2" )]
        public long? Uid2 { get; set; }

    }
}
