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
    /// http://developers.facebook.com/docs/reference/fql/friendlist/
    /// </summary>
    [Table(Name = "friendlist")]
    public class Friendlist
    {
        /// <summary>
        /// The ID of the user who created the friend list.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "owner" , IsPrimaryKey = true)]
        public Uid Owner { get; set; }

        /// <summary>
        /// The ID of the friend list. <strong>Note:</strong> This is only indexable for friend lists belonging to the current session user
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "flid" )]
        public FriendListId Flid { get; set; }

        /// <summary>
        /// The name of the friend list.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The type of the friends list; Possible values are: close_friends, acquaintances, restricted,user_created, education, work, current_city or family.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

    }
}
