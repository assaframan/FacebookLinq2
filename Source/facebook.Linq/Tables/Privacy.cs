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
    /// http://developers.facebook.com/docs/reference/fql/privacy/
    /// </summary>
    [Table(Name = "privacy")]
    public class Privacy
    {
        /// <summary>
        /// The ID of any video, note, link, photo, or photo album published by the current session user
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public string Id { get; set; }

        /// <summary>
        /// <code>id</code> is an alias of this column
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "object_id" )]
        public string ObjectId { get; set; }

        /// <summary>
        /// The privacy value for the object, one of:
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "value " )]
        public string Value { get; set; }

        /// <summary>
        /// A description of the privacy settings. For custom settings, it can contain names of users, networks, and friend lists
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The UIDs of the specific users or the IDs of <a href="/docs/reference/fql/friendlist/">friendlists</a> that can see the object (as a comma-separated string)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "allow" )]
        public string Allow { get; set; }

        /// <summary>
        /// The UIDs of the specific users or the IDs of <a href="/docs/reference/fql/friendlist/">friendlists</a> that cannot see the object (as a comma-separated string)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "deny" )]
        public string Deny { get; set; }

        /// <summary>
        /// The ID of the user who owns the object
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "owner_id" )]
        public long OwnerId { get; set; }

        /// <summary>
        /// The ID of the network that can see the object, or 1 for all of the user's networks.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "networks" )]
        public long Networks { get; set; }

        /// <summary>
        /// Which users can see the object. Can be one of:
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "friends" )]
        public string Friends { get; set; }

    }
}
