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
    /// http://developers.facebook.com/docs/reference/fql/page/
    /// </summary>
    [Table(Name = "page")]
    public class Page
    {
        /// <summary>
        /// The ID of the Page.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "page_id" , IsPrimaryKey = true)]
        public PageId PageId { get; set; }

        /// <summary>
        /// The name of the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The username of the Page, eg. For www.facebook.com/platform the username is 'platform'.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "username" )]
        public string Username { get; set; }

        /// <summary>
        /// The description of the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The absolute URL to the page on Facebook, e.g. https://www.facebook.com/platform
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_url" )]
        public string PageUrl { get; set; }

        /// <summary>
        /// The categories of the Page.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "categories" )]
        public JsonObject Categories { get; set; }

        /// <summary>
        /// Indicates whether the Page is a community Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "is_community_page" )]
        public string IsCommunityPage { get; set; }

        /// <summary>
        /// The URL to the small-sized picture for the Page. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The URL to the large-sized profile picture for the Page. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the Page. The image can have a maximum width and height of 50px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// The URL to the medium-sized profile picture for the Page. The image can have a maximum width of 100px and a maximum height of 300px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the Page. The image can have a maximum width of 396px and a maximum height of 1188px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_large" )]
        public string PicLarge { get; set; }

        /// <summary>
        /// The JSON object containing three fields: cover_id (the ID of the cover photo), source (the URL for the cover photo), and offset_y (indicating percentage offset from top [0-100])
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "pic_cover" )]
        public JsonObject PicCover { get; set; }

        /// <summary>
        /// Number of unread notifications. Only viewable by the page admin.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "unread_notif_count" )]
        public long? UnreadNotifCount { get; set; }

        /// <summary>
        /// The number of people who have liked the Page, since the last login. Only viewable by the page admin.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "new_like_count" )]
        public long? NewLikeCount { get; set; }

        /// <summary>
        /// The number of people who like the Page.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "fan_count" )]
        public long? FanCount { get; set; }

        /// <summary>
        /// The type of Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The URL to the Web site of the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website" )]
        public string Website { get; set; }

        /// <summary>
        /// Indicates whether this Page has added the app making the query in a Page tab.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "has_added_app" )]
        public bool? HasAddedApp { get; set; }

        /// <summary>
        /// General information provided by the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "general_info" )]
        public string GeneralInfo { get; set; }

        /// <summary>
        /// Indicates whether the current session user can post on this Page.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_post" )]
        public bool? CanPost { get; set; }

        /// <summary>
        /// Number of checkins at a place represented by a Page.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "checkins" )]
        public long? Checkins { get; set; }

        /// <summary>
        /// Indicates whether the Page is published and visible to non-admins.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_published" )]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Applicable to <strong>Companies</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "founded" )]
        public string Founded { get; set; }

        /// <summary>
        /// Applicable to <strong>Companies</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "company_overview" )]
        public string CompanyOverview { get; set; }

        /// <summary>
        /// Applicable to <strong>Companies</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "mission" )]
        public string Mission { get; set; }

        /// <summary>
        /// Applicable to <strong>Companies</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "products" )]
        public string Products { get; set; }

        /// <summary>
        /// Applicable to all <strong>Places</strong>.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "location" )]
        public JsonObject Location { get; set; }

        /// <summary>
        /// Applicable to <strong>Businesses</strong> and <strong>Places</strong>. Can be one of street, lot or valet
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "parking" )]
        public JsonObject Parking { get; set; }

        /// <summary>
        /// Applicable to <strong>Businesses</strong> and <strong>Places</strong>.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "hours" )]
        public JsonObject Hours { get; set; }

        /// <summary>
        /// Applicable to <strong>Pharmaceutical</strong> companies.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pharma_safety_info" )]
        public string PharmaSafetyInfo { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "public_transit" )]
        public string PublicTransit { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>. Can be one of Casual, Dressy or Unspecified.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "attire" )]
        public string Attire { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "payment_options" )]
        public JsonObject PaymentOptions { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "culinary_team" )]
        public string CulinaryTeam { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "general_manager" )]
        public string GeneralManager { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>. Can be one of $ (0-10), $$ (10-30), $$$ (30-50), $$$$ (50+) or Unspecified.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "price_range" )]
        public string PriceRange { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong>.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "restaurant_services" )]
        public JsonObject RestaurantServices { get; set; }

        /// <summary>
        /// Applicable to <strong>Restaurants</strong>.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "restaurant_specialties" )]
        public JsonObject RestaurantSpecialties { get; set; }

        /// <summary>
        /// Phone number provided by a Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "phone" )]
        public string Phone { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "release_date" )]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "genre" )]
        public string Genre { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "starring" )]
        public string Starring { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "screenplay_by" )]
        public string ScreenplayBy { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "directed_by" )]
        public string DirectedBy { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "produced_by" )]
        public string ProducedBy { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "studio" )]
        public string Studio { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "awards" )]
        public string Awards { get; set; }

        /// <summary>
        /// Applicable to <strong>Films</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "plot_outline" )]
        public string PlotOutline { get; set; }

        /// <summary>
        /// Applicable to <strong>TV Shows</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "season" )]
        public string Season { get; set; }

        /// <summary>
        /// Applicable to <strong>TV Shows</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "network" )]
        public string Network { get; set; }

        /// <summary>
        /// Applicable to <strong>TV Shows</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "schedule" )]
        public string Schedule { get; set; }

        /// <summary>
        /// Applicable to <strong>TV Shows</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "written_by" )]
        public string WrittenBy { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "band_members" )]
        public string BandMembers { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "hometown" )]
        public string Hometown { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "current_location" )]
        public string CurrentLocation { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "record_label" )]
        public string RecordLabel { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "booking_agent" )]
        public string BookingAgent { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "press_contact" )]
        public string PressContact { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "artists_we_like" )]
        public string ArtistsWeLike { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "influences" )]
        public string Influences { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "band_interests" )]
        public string BandInterests { get; set; }

        /// <summary>
        /// Applicable to <strong>Bands</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "bio" )]
        public string Bio { get; set; }

        /// <summary>
        /// Applicable to Pages representing <strong>People</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "affiliation" )]
        public string Affiliation { get; set; }

        /// <summary>
        /// Applicable to Pages representing <strong>People</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday" )]
        public string Birthday { get; set; }

        /// <summary>
        /// Applicable to Pages representing <strong>People</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "personal_info" )]
        public string PersonalInfo { get; set; }

        /// <summary>
        /// Applicable to Pages representing <strong>People</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "personal_interests" )]
        public string PersonalInterests { get; set; }

        /// <summary>
        /// Applicable to <strong>Vehicles</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "built" )]
        public string Built { get; set; }

        /// <summary>
        /// Applicable to <strong>Vehicles</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "features" )]
        public string Features { get; set; }

        /// <summary>
        /// Applicable to <strong>Vehicles</strong>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "mpg" )]
        public string Mpg { get; set; }

    }
}
