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
    /// https://developers.facebook.com/docs/reference/fql/group_member
    /// </summary>
    [Table(Name = "group_member")]
    public class GroupMember
    {
        /// <summary>
        /// Returns true if the user is an administrator of the group.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "administrator" , IsPrimaryKey = true)]
        public bool? Administrator { get; set; }

        /// <summary>
        /// The order in which the group appears in the user's list of groups. This field requires the user_groups permission, and is only present when you query by uid
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "bookmark_order" )]
        public object BookmarkOrder { get; set; }

        /// <summary>
        /// The ID of the group being queried.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "gid" )]
        public GroupId Gid { get; set; }

        /// <summary>
        /// Any positions taken by the member of the group being queried. Possible values are OWNER, ADMIN or OFFICER
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "positions" )]
        public object Positions { get; set; }

        /// <summary>
        /// The user ID of the member of the group being queried.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

        /// <summary>
        /// A count of items in this group which have not been read by the user. This field requires the user_groups permission, and is only present when you query by uid
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "unread" )]
        public object Unread { get; set; }

    }
}
