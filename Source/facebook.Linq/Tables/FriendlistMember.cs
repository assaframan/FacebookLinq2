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
    /// https://developers.facebook.com/docs/reference/fql/friendlist_member
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
        public FriendListId Flid { get; set; }

        /// <summary>
        /// A cursor used to paginate through a query that is indexed on the owner
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "flid_cursor" )]
        public string FlidCursor { get; set; }

        /// <summary>
        /// The user ID of the friend list member.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

    }
}
