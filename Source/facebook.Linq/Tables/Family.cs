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
    /// http://developers.facebook.com/docs/reference/fql/family/
    /// </summary>
    [Table(Name = "family")]
    public class Family
    {
        /// <summary>
        /// The ID of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_id" , IsPrimaryKey = true)]
        public Uid ProfileId { get; set; }

        /// <summary>
        /// The user ID of the relative, which is returned if the relationship is confirmed and links to another profile.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

        /// <summary>
        /// The name of the relative, which is returned if the relationship is not linked to another profile.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The birthday of the relative, which is returned if the relationship is not linked to another profile.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday" )]
        public string Birthday { get; set; }

        /// <summary>
        /// A string describing how the relative is related to the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "relationship" )]
        public string Relationship { get; set; }

    }
}
