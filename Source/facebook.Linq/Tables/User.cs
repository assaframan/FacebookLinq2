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
    /// https://developers.facebook.com/docs/reference/fql/user
    /// </summary>
    [Table(Name = "user")]
    public class User
    {
        /// <summary>
        /// More information about the user being queried
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "about_me" , IsPrimaryKey = true)]
        public string AboutMe { get; set; }

        /// <summary>
        /// The user's activities
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "activities" )]
        public string Activities { get; set; }

        /// <summary>
        /// The networks to which the user being queried belongs. The status field within this field will only return results in English
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "affiliations" )]
        public object Affiliations { get; set; }

        /// <summary>
        /// The user's age range. May be 13-17, 18-20 or 21+.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "age_range" )]
        public object AgeRange { get; set; }

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
        /// The user's birthday in MM/DD/YYYY format
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday_date" )]
        public string BirthdayDate { get; set; }

        /// <summary>
        /// The user's favorite books
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "books" )]
        public string Books { get; set; }

        /// <summary>
        /// Whether the user can send a message to another user
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_message" )]
        public bool? CanMessage { get; set; }

        /// <summary>
        /// Whether or not the viewer can post to the user's Wall
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_post" )]
        public bool? CanPost { get; set; }

        /// <summary>
        /// A string containing the user's primary Facebook email address. If the user shared his or her primary email address with you, this address also appears in the email field (see below). Facebook recommends you query the email field to get the email address shared with your application
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "contact_email" )]
        public string ContactEmail { get; set; }

        /// <summary>
        /// The user's default currencty
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "currency" )]
        public object Currency { get; set; }

        /// <summary>
        /// The current address of the user
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "current_address" )]
        public object CurrentAddress { get; set; }

        /// <summary>
        /// The user's current location
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "current_location" )]
        public object CurrentLocation { get; set; }

        /// <summary>
        /// An array of objects containing fields os, which may be a value of 'iOS' or 'Android', along with an additional field hardware which may be a value of 'iPad' or 'iPhone', if present. However, hardware may not be returned if we are unable to determine the exact hardware model and only the os
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "devices" )]
        public Devices Devices { get; set; }

        /// <summary>
        /// A list of the user's education history. Contains year and type fields, and school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "education" )]
        public object Education { get; set; }

        /// <summary>
        /// A string containing the user's primary Facebook email address or the user's proxied email address, whichever address the user granted your application. Facebook recommends you query this field to get the email address shared with your application
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "email" )]
        public string Email { get; set; }

        /// <summary>
        /// An array containing a set of confirmed email hashes for the user. The format of each email hash is the crc32 and md5 hashes of the email address combined with an underscore (_)
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "email_hashes" )]
        public object EmailHashes { get; set; }

        /// <summary>
        /// The user's first name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "first_name" )]
        public string FirstName { get; set; }

        /// <summary>
        /// Count of all the user's friends
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "friend_count" )]
        public object FriendCount { get; set; }

        /// <summary>
        /// The user's number of outstanding friend requests
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "friend_request_count" )]
        public object FriendRequestCount { get; set; }

        /// <summary>
        /// Whether the user has a timeline or linkable profile
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "has_timeline" )]
        public bool? HasTimeline { get; set; }

        /// <summary>
        /// The user's hometown (and state)
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "hometown_location" )]
        public HometownLocationType HometownLocation { get; set; }

        /// <summary>
        /// The people who inspire the user
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "inspirational_people" )]
        public object InspirationalPeople { get; set; }

        /// <summary>
        /// App install type of the user
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "install_type" )]
        public string InstallType { get; set; }

        /// <summary>
        /// The user's interests
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "interests" )]
        public string Interests { get; set; }

        /// <summary>
        /// Indicates whether the user being queried has logged in to the current application
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_app_user" )]
        public bool? IsAppUser { get; set; }

        /// <summary>
        /// Whether the user is blocked by the current session user
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_blocked" )]
        public bool? IsBlocked { get; set; }

        /// <summary>
        /// Whether the user is a minor
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_minor" )]
        public bool? IsMinor { get; set; }

        /// <summary>
        /// The user's languages
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "languages" )]
        public object Languages { get; set; }

        /// <summary>
        /// The user's last name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_name" )]
        public string LastName { get; set; }

        /// <summary>
        /// Count of all the pages this user has liked
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "likes_count" )]
        public object LikesCount { get; set; }

        /// <summary>
        /// The two-letter language code and the two-letter country code representing the user's <a href="http://www.facebook.com/translations/FacebookLocales.xml">locale</a>. Country codes are taken from the <a href="http://www.iso.org/iso/iso-3166-1_decoding_table.htmllist">ISO 3166 alpha 2 code</a>
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "locale" )]
        public string Locale { get; set; }

        /// <summary>
        /// A list of the reasons the user being queried wants to meet someone
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "meeting_for" )]
        public object MeetingFor { get; set; }

        /// <summary>
        /// A list of the genders the person the user being queried wants to meet
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "meeting_sex" )]
        public Genders MeetingSex { get; set; }

        /// <summary>
        /// The user's middle name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "middle_name" )]
        public string MiddleName { get; set; }

        /// <summary>
        /// The user's favorite movies
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "movies" )]
        public string Movies { get; set; }

        /// <summary>
        /// The user's favorite music
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "music" )]
        public string Music { get; set; }

        /// <summary>
        /// The number of mutual friends shared by the user being queried and the session user
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "mutual_friend_count" )]
        public object MutualFriendCount { get; set; }

        /// <summary>
        /// The user's full name
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The user's name formatted to correctly handle Chinese, Japanese, Korean ordering
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name_format" )]
        public string NameFormat { get; set; }

        /// <summary>
        /// The number of notes created by the user being queried
        /// 
        /// original type is: (number) or (bool)
        /// </summary>
        [Column(Name = "notes_count" )]
        public object NotesCount { get; set; }

        /// <summary>
        /// The user's Facebook Chat status. Returns a string, one of active, idle, offline, or error (when Facebook can't determine presence information on the server side). The query does not return the user's Facebook Chat status when that information is restricted for privacy reasons
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "online_presence" )]
        public string OnlinePresence { get; set; }

        /// <summary>
        /// The user's (hashed) payment instruments
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "payment_instruments" )]
        public object PaymentInstruments { get; set; }

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
        /// The URL to the medium-sized profile picture for the user being queried. The image can have a maximum width of 100px and a maximum height of 300px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the user being queried. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the user being queried. The image can have a maximum width of 200px and a maximum height of 600px, and is overlaid with the Facebook favicon. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big_with_logo" )]
        public string PicBigWithLogo { get; set; }

        /// <summary>
        /// An array containing the keys cover_id, source, and offset_y which refer to the user's cover photo
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "pic_cover" )]
        public object PicCover { get; set; }

        /// <summary>
        /// The URL to the small-sized profile picture for the user being queried. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The URL to the small-sized profile picture for the user being queried. The image can have a maximum width of 50px and a maximum height of 150px, and is overlaid with the Facebook favicon. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small_with_logo" )]
        public string PicSmallWithLogo { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the user being queried. The image can have a maximum width and height of 50px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the user being queried. The image can have a maximum width and height of 50px, and is overlaid with the Facebook favicon. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square_with_logo" )]
        public string PicSquareWithLogo { get; set; }

        /// <summary>
        /// The URL to the medium-sized profile picture for the user being queried. The image can have a maximum width of 100px and a maximum height of 300px, and is overlaid with the Facebook favicon. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_with_logo" )]
        public string PicWithLogo { get; set; }

        /// <summary>
        /// The user's political views
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "political" )]
        public string Political { get; set; }

        /// <summary>
        /// This string contains the contents of the text box under a user's profile picture
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_blurb" )]
        public string ProfileBlurb { get; set; }

        /// <summary>
        /// The time the profile was most recently updated (UNIX timestamp). If the user's profile has not been updated in the past three days, this value will be 0
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "profile_update_time" )]
        public DateTime? ProfileUpdateTime { get; set; }

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
        /// The user's favorite quotes
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "quotes" )]
        public string Quotes { get; set; }

        /// <summary>
        /// The type of relationship for the user being queried
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "relationship_status" )]
        public string RelationshipStatus { get; set; }

        /// <summary>
        /// The user's religion
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "religion" )]
        public string Religion { get; set; }

        /// <summary>
        /// The search tokens for the user
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "search_tokens" )]
        public object SearchTokens { get; set; }

        /// <summary>
        /// Security settings of the user
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "security_settings" )]
        public object SecuritySettings { get; set; }

        /// <summary>
        /// The user's gender
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sex" )]
        public string Sex { get; set; }

        /// <summary>
        /// The user's shipping information
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "shipping_information" )]
        public object ShippingInformation { get; set; }

        /// <summary>
        /// The user ID of the partner (for example, husband, wife, boyfriend, girlfriend)
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "significant_other_id" )]
        public Uid SignificantOtherId { get; set; }

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
        /// The sports that the user plays. The array objects contain id and name fields
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "sports" )]
        public object Sports { get; set; }

        /// <summary>
        /// The user's current status
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "status" )]
        public UserStatus Status { get; set; }

        /// <summary>
        /// The user's total number of subscribers
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "subscriber_count" )]
        public object SubscriberCount { get; set; }

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
        /// The user's favorite television shows
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "tv" )]
        public string Tv { get; set; }

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

        /// <summary>
        /// Indicates whether or not Facebook has verified the user
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "verified" )]
        public bool? Verified { get; set; }

        /// <summary>
        /// The size of the video file and the length of the video that a user can upload. This object contains length and size of video
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "video_upload_limits" )]
        public object VideoUploadLimits { get; set; }

        /// <summary>
        /// Whether the viewer can send gift to this user
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "viewer_can_send_gift" )]
        public bool? ViewerCanSendGift { get; set; }

        /// <summary>
        /// The number of Wall posts for the user being queried
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "wall_count" )]
        public object WallCount { get; set; }

        /// <summary>
        /// The website
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website" )]
        public string Website { get; set; }

        /// <summary>
        /// A list of the user's work history. Contains employer, location, position, start_date and end_date fields
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "work" )]
        public object Work { get; set; }

        /// <summary>
        /// For family information, you should query the <a href="/docs/reference/fql/family">family</a> FQL table instead
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "family" )]
        public object Family { get; set; }

    }
}
