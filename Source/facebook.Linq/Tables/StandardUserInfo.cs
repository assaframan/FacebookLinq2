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
    /// https://developers.facebook.com/docs/reference/fql/standard_user_info
    /// </summary>
    [Table(Name = "standard_user_info")]
    public class StandardUserInfo
    {
        /// <summary>
        /// The networks to which the user being queried belongs. The status field within this field will only return results in English
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "affiliations" , IsPrimaryKey = true)]
        public object Affiliations { get; set; }

        /// <summary>
        /// A comma-delimited list of demographic restriction types a user is allowed to access. Currently, alcohol is the only type that can get returned
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "allowed_restrictions" )]
        public string AllowedRestrictions { get; set; }

        /// <summary>
        /// The user's birthday. The format of this date varies based on the user's locale
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday" )]
        public string Birthday { get; set; }

        /// <summary>
        /// User's credits currency
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "credit_currency" )]
        public object CreditCurrency { get; set; }

        /// <summary>
        /// User's credit deals
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "credit_deals" )]
        public object CreditDeals { get; set; }

        /// <summary>
        /// The user's current location
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "current_location" )]
        public object CurrentLocation { get; set; }

        /// <summary>
        /// A string containing the user's primary Facebook email address or the user's proxied email address, whichever address the user granted your application. Facebook recommends you query this field to get the email address shared with your application
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "email" )]
        public string Email { get; set; }

        /// <summary>
        /// The user's first name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "first_name" )]
        public string FirstName { get; set; }

        /// <summary>
        /// Whether the user is a minor
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_minor" )]
        public bool? IsMinor { get; set; }

        /// <summary>
        /// The user's last name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_name" )]
        public string LastName { get; set; }

        /// <summary>
        /// The two-letter language code and the two-letter country code representing the user's <a href="http://www.facebook.com/translations/FacebookLocales.xml">locale</a>. Country codes are taken from the <a href="http://www.iso.org/iso/iso-3166-1_decoding_table.htmllist">ISO 3166 alpha 2 code</a>
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "locale" )]
        public string Locale { get; set; }

        /// <summary>
        /// The user's full name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The user's payment price points for mobile phone
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "payment_mobile_pricepoints" )]
        public object PaymentMobilePricepoints { get; set; }

        /// <summary>
        /// The user's payment price points
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "payment_pricepoints" )]
        public object PaymentPricepoints { get; set; }

        /// <summary>
        /// The URL to a user's profile
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_url" )]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// The proxied wrapper for a user's email address. If the user shared a proxied email address instead of his or her primary email address with you, this address also appears in the email field (see above). Facebook recommends you query the email field to get the email address shared with your application
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "proxied_email" )]
        public string ProxiedEmail { get; set; }

        /// <summary>
        /// The user's gender
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sex" )]
        public string Sex { get; set; }

        /// <summary>
        /// The user's first name, if the user has a Japanese name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sort_first_name" )]
        public string SortFirstName { get; set; }

        /// <summary>
        /// The user's last name, if the user has a Japanese name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sort_last_name" )]
        public string SortLastName { get; set; }

        /// <summary>
        /// A string containing an anonymous, but unique identifier for the user. You can use this identifier with third-parties
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "third_party_id" )]
        public ThirdPartyId ThirdPartyId { get; set; }

        /// <summary>
        /// The user's timezone offset from UTC
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "timezone" )]
        public object Timezone { get; set; }

        /// <summary>
        /// The user ID
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

        /// <summary>
        /// The user's username
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "username" )]
        public string Username { get; set; }

    }
}
