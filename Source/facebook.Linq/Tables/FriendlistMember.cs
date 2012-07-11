using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/friendlist_member/
    /// </summary>
    [Table(Name = "friendlist_member")]
    public class FriendlistMember
    {
        /// <summary>
        /// The ID of the friendlist.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "flid" , IsPrimaryKey = true)]
        public string Flid { get; set; }

        /// <summary>
        /// The user ID of the friend list member.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" )]
        public string Uid { get; set; }

    }
}
