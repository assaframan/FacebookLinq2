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
    /// https://developers.facebook.com/docs/reference/fql/privacy
    /// </summary>
    [Table(Name = "privacy")]
    public class Privacy
    {
        /// <summary>
        /// The UIDs of the specific users or the IDs of friendlists that can see the object (as a comma-separated string).
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "allow" , IsPrimaryKey = true)]
        public string Allow { get; set; }

        /// <summary>
        /// The UIDs of the specific users or the IDs of friendlists that cannot see the object (as a comma-separated string).
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "deny" )]
        public string Deny { get; set; }

        /// <summary>
        /// A description of the privacy settings. For custom settings, it can contain names of users, networks, and friend lists.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// Which users can see the object. Can be one of: EVERYONE, FRIENDS_OF_FRIENDS, ALL_FRIENDS, SOME_FRIENDS, SELF, NO_FRIENDS
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "friends" )]
        public string Friends { get; set; }

        /// <summary>
        /// The ID of any video, note, link, photo, or photo album published by the current session user.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "id" )]
        public ObjectId Id { get; set; }

        /// <summary>
        /// The ID of the network that can see the object, or ALL_NETWORKS for all of the user's networks.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "networks" )]
        public string Networks { get; set; }

        /// <summary>
        /// id is an alias of this column.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "object_id" )]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// The ID of the user who owns the object.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "owner_id" )]
        public Uid OwnerId { get; set; }

        /// <summary>
        /// The privacy value for the object, one of: EVERYONE, CUSTOM, ALL_FRIENDS, FRIENDS_OF_FRIENDS
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "value" )]
        public string Value { get; set; }

    }
}
