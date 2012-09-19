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
    /// http://developers.facebook.com/docs/reference/fql/user/
    /// </summary>
    [Table(Name = "user")]
    public class User
    {
        /// <summary>
        /// The user ID of the user being queried.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public Uid Uid { get; set; }

        /// <summary>
        /// The username of the user being queried.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "username" )]
        public string Username { get; set; }

        /// <summary>
        /// The first name of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "first_name" )]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "middle_name" )]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_name" )]
        public string LastName { get; set; }

        /// <summary>
        /// The full name of the user being queried.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The URL to the small-sized profile picture for the user being queried. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the user being queried. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the user being queried. The image can have a maximum width and height of 50px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// The URL to the medium-sized profile picture for the user being queried. The image can have a maximum width of 100px and a maximum height of 300px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The networks to which the user being queried belongs. The status field within this field will only return results in English.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "affiliations" )]
        public object Affiliations { get; set; }

        /// <summary>
        /// The time the profile of the user being queried was most recently updated. If the user's profile has not been updated in the past three days, this value will be 0.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "profile_update_time" )]
        public DateTime? ProfileUpdateTime { get; set; }

        /// <summary>
        /// The user's timezone offset from UTC.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "timezone" )]
        public long? Timezone { get; set; }

        /// <summary>
        /// The religion of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "religion" )]
        public string Religion { get; set; }

        /// <summary>
        /// The birthday of the user being queried. The format of this date varies based on the user's locale.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday" )]
        public string Birthday { get; set; }

        /// <summary>
        /// The birthday of the user being queried in MM/DD/YYYY format.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday_date" )]
        public string BirthdayDate { get; set; }

        /// <summary>
        /// An array of objects containing fields os, which may be a value of 'iOS' or 'Android', along with an additional field hardware which may be a value of 'iPad' or 'iPhone', if present. However, hardware may not be returned if we are unable to determine the exact hardware model and only the os.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "devices" )]
        public Devices Devices { get; set; }

        /// <summary>
        /// The gender of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sex" )]
        public string Sex { get; set; }

        /// <summary>
        /// The hometown (and state) of the user being queried.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "hometown_location" )]
        public HometownLocationType HometownLocation { get; set; }

        /// <summary>
        /// A list of the genders the person the user being queried wants to meet.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "meeting_sex" )]
        public Genders MeetingSex { get; set; }

        /// <summary>
        /// A list of the reasons the user being queried wants to meet someone.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "meeting_for" )]
        public object MeetingFor { get; set; }

        /// <summary>
        /// The type of relationship for the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "relationship_status" )]
        public string RelationshipStatus { get; set; }

        /// <summary>
        /// The user ID of the partner (for example, husband, wife, boyfriend, girlfriend) of the user being queried.
        /// 
        /// original type is: uid
        /// </summary>
        [Column(Name = "significant_other_id" )]
        public Uid SignificantOtherId { get; set; }

        /// <summary>
        /// The political views of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "political" )]
        public string Political { get; set; }

        /// <summary>
        /// The current location of the user being queried.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "current_location" )]
        public object CurrentLocation { get; set; }

        /// <summary>
        /// The activities of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "activities" )]
        public string Activities { get; set; }

        /// <summary>
        /// The interests of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "interests" )]
        public string Interests { get; set; }

        /// <summary>
        /// Indicates whether the user being queried has logged in to the current application.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_app_user" )]
        public bool? IsAppUser { get; set; }

        /// <summary>
        /// The favorite music of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "music" )]
        public string Music { get; set; }

        /// <summary>
        /// The favorite television shows of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "tv" )]
        public string Tv { get; set; }

        /// <summary>
        /// The favorite movies of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "movies" )]
        public string Movies { get; set; }

        /// <summary>
        /// The favorite books of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "books" )]
        public string Books { get; set; }

        /// <summary>
        /// The favorite quotes of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "quotes" )]
        public string Quotes { get; set; }

        /// <summary>
        /// More information about the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "about_me" )]
        public string AboutMe { get; set; }

        /// <summary>
        /// The number of notes created by the user being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "notes_count" )]
        public long? NotesCount { get; set; }

        /// <summary>
        /// The number of Wall posts for the user being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "wall_count" )]
        public long? WallCount { get; set; }

        /// <summary>
        /// The current status of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "status" )]
        public string Status { get; set; }

        /// <summary>
        /// The user's Facebook Chat status. Returns a string, one of active, idle, offline, or error (when Facebook can't determine presence information on the server side). The query does not return the user's Facebook Chat status when that information is restricted for privacy reasons.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "online_presence" )]
        public string OnlinePresence { get; set; }

        /// <summary>
        /// The two-letter language code and the two-letter country code representing the user's <a href="http://www.facebook.com/translations/FacebookLocales.xml">locale</a>. Country codes are taken from the <a href="http://www.iso.org/iso/iso-3166-1_decoding_table.html">ISO 3166 alpha 2 code</a> list.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "locale" )]
        public string Locale { get; set; }

        /// <summary>
        /// The proxied wrapper for a user's email address. If the user shared a proxied email address instead of his or her primary email address with you, this address also appears in the email field (see above). Facebook recommends you query the email field to get the email address shared with your application.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "proxied_email" )]
        public string ProxiedEmail { get; set; }

        /// <summary>
        /// The URL to a user's profile. If the user specified a username for his or her profile, profile_url contains the username.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_url" )]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// The URL to the small-sized profile picture for the user being queried. The image can have a maximum width of 50px and a maximum height of 150px, and is overlaid with the Facebook favicon. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small_with_logo" )]
        public string PicSmallWithLogo { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the user being queried. The image can have a maximum width of 200px and a maximum height of 600px, and is overlaid with the Facebook favicon. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big_with_logo" )]
        public string PicBigWithLogo { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the user being queried. The image can have a maximum width and height of 50px, and is overlaid with the Facebook favicon. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square_with_logo" )]
        public string PicSquareWithLogo { get; set; }

        /// <summary>
        /// The URL to the medium-sized profile picture for the user being queried. The image can have a maximum width of 100px and a maximum height of 300px, and is overlaid with the Facebook favicon. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_with_logo" )]
        public string PicWithLogo { get; set; }

        /// <summary>
        /// An array containing the keys cover_id, source, and offset_y which refer to the user's cover photo.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "pic_cover" )]
        public object PicCover { get; set; }

        /// <summary>
        /// A comma-delimited list of <a href="/docs/reference/rest/admin.setRestrictionInfo">Demographic Restrictions</a> types a user is allowed to access. Currently, alcohol is the only type that can get returned.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "allowed_restrictions" )]
        public string AllowedRestrictions { get; set; }

        /// <summary>
        /// Indicates whether or not Facebook has verified the user.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "verified" )]
        public bool? Verified { get; set; }

        /// <summary>
        /// This string contains the contents of the text box under a user's profile picture.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_blurb" )]
        public string ProfileBlurb { get; set; }

        /// <summary>
        /// <strong>Note:</strong> For family information, you should query the <a href="/docs/reference/fql/family/">family</a> FQL table instead.</p>
        /// 
        /// <p>This array contains a series of entries for the immediate relatives of the user being queried. Each entry is also an array containing the following fields:</p>
        /// 
        /// <ul>
        /// <li>relationship -- A string describing the type of relationship. Can be one of parent, mother, father, sibling, sister, brother, child, son, daughter.</li>
        /// <li>uid (optional) -- The user ID of the relative, which gets displayed if the account is linked to (confirmed by) another account. If the relative did not confirm the relationship, the name appears instead.</li>
        /// <li>name (optional) -- The name of the relative, which could be text the user entered. If the relative confirmed the relationship, the uid appears instead.</li>
        /// <li>birthday -- If the relative is a child, this is the birthday the user entered.</li>
        /// </ul>
        /// 
        /// <p><strong>Note:</strong> At this time, you cannot query for a specific relationship (like SELECT family FROM user WHERE family.relationship = 'daughter' AND uid = '$x'); you'll have to query on the family field and filter the results yourself.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "family" )]
        public object Family { get; set; }

        /// <summary>
        /// The website of the user being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website" )]
        public string Website { get; set; }

        /// <summary>
        /// Returns true if the user is blocked to the viewer/logged in user.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_blocked" )]
        public bool? IsBlocked { get; set; }

        /// <summary>
        /// A string containing the user's primary Facebook email address. If the user shared his or her primary email address with you, this address also appears in the email field (see below). Facebook recommends you query the email field to get the email address shared with your application.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "contact_email" )]
        public string ContactEmail { get; set; }

        /// <summary>
        /// A string containing the user's primary Facebook email address or the user's proxied email address, whichever address the user granted your application. Facebook recommends you query this field to get the email address shared with your application.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "email" )]
        public string Email { get; set; }

        /// <summary>
        /// A string containing an anonymous, but unique identifier for the user.  You can use this identifier with third-parties.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "third_party_id" )]
        public ThirdPartyId ThirdPartyId { get; set; }

        /// <summary>
        /// The user's name formatted to correctly handle Chinese, Japanese, Korean ordering.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name_format" )]
        public string NameFormat { get; set; }

        /// <summary>
        /// The size of the video file and the length of the video that a user can upload. This object contains length and size of video.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "video_upload_limits" )]
        public object VideoUploadLimits { get; set; }

        /// <summary>
        /// A list of the user's work history. Contains employer, location, position, start_date and end_date fields.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "work" )]
        public object Work { get; set; }

        /// <summary>
        /// A list of the user's education history. Contains year and type fields, and school object (name, id, type, and optional year, degree, concentration array, classes array, and with array ).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "education" )]
        public object Education { get; set; }

        /// <summary>
        /// The sports that the user plays. The array objects contain id and name fields.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "sports" )]
        public object Sports { get; set; }

        /// <summary>
        /// The people who inspire the user. The array objects contain id and name fields.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "inspirational_people" )]
        public object InspirationalPeople { get; set; }

        /// <summary>
        /// The user's languages. The array objects contain id and name fields.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "languages" )]
        public object Languages { get; set; }

        /// <summary>
        /// Count of all the pages this user has liked.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "likes_count" )]
        public long? LikesCount { get; set; }

        /// <summary>
        /// Count of all the user's friends.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "friend_count" )]
        public long? FriendCount { get; set; }

        /// <summary>
        /// The number of mutual friends shared by the user in the query and the session user.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "mutual_friend_count" )]
        public long? MutualFriendCount { get; set; }

        /// <summary>
        /// Whether or not the viewer can post to the user's Wall.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_post" )]
        public bool? CanPost { get; set; }

    }
}
