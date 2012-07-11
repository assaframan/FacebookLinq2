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
    /// http://developers.facebook.com/docs/reference/fql/group_member/
    /// </summary>
    [Table(Name = "group_member")]
    public class GroupMember
    {
        /// <summary>
        /// The user ID of the member of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public string Uid { get; set; }

        /// <summary>
        /// The ID of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "gid" )]
        public string Gid { get; set; }

        /// <summary>
        /// Returns true if the user is an administrator of the group.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "administrator" )]
        public bool? Administrator { get; set; }

        /// <summary>
        /// Any positions taken by the member of the group being queried. Possible values are <code>OWNER</code>, <code>ADMIN</code> or <code>OFFICER</code>
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "positions" )]
        public string Positions { get; set; }

        /// <summary>
        /// A count of items in this group which have not been read by the user. This field requires the <code>user_groups</code> permission, and is only present when you query by <code>uid</code>
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "unread" )]
        public long? Unread { get; set; }

        /// <summary>
        /// The order in which the group appears in the user's list of groups. This field requires the <code>user_groups</code> permission, and is only present when you query by <code>uid</code>
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "bookmark_order" )]
        public long? BookmarkOrder { get; set; }

    }
}
