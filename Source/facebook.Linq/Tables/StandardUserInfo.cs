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
    /// http://developers.facebook.com/docs/reference/fql/standard_user_info/
    /// </summary>
    [Table(Name = "standard_user_info")]
    public class StandardUserInfo
    {
        /// <summary>
        /// The user ID of the user being queried.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public Uid Uid { get; set; }

        /// <summary>
        /// The full name of the user.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The username of the user.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "username" )]
        public string Username { get; set; }

        /// <summary>
        /// Third party ID of the user.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "third_party_id" )]
        public ThirdPartyId ThirdPartyId { get; set; }

        /// <summary>
        /// The first name of the user.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "first_name" )]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_name" )]
        public string LastName { get; set; }

        /// <summary>
        /// The two-letter country code for the user's locale. Codes used are the <a href="http://www.iso.org/iso/iso-3166-1_decoding_table.html">ISO 3166 alpha 2 code</a> list.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "locale" )]
        public string Locale { get; set; }

        /// <summary>
        /// The corporate or educational networks to which the user being queried belongs. Regional networks have been deprecated and are no longer returned.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "affiliations" )]
        public JsonObject Affiliations { get; set; }

        /// <summary>
        /// The URL to a user's profile.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_url" )]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// The time zone where the user being queried is located.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "timezone" )]
        public string Timezone { get; set; }

        /// <summary>
        /// The birthday of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday" )]
        public string Birthday { get; set; }

        /// <summary>
        /// The sex of the user.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sex" )]
        public string Sex { get; set; }

        /// <summary>
        /// The proxied wrapper for a user's email address.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "proxied_email" )]
        public string ProxiedEmail { get; set; }

        /// <summary>
        /// The city in which the user currently lives.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "current_location" )]
        public string CurrentLocation { get; set; }

        /// <summary>
        /// A comma delimited list of Demographic Restrictions types a user is allowed to access. Currently, alcohol is the only type that can be returned.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "allowed_restrictions" )]
        public string AllowedRestrictions { get; set; }

    }
}
