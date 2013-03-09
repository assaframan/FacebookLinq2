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
    /// https://developers.facebook.com/docs/reference/fql/page
    /// </summary>
    [Table(Name = "page")]
    public class Page
    {
        /// <summary>
        /// The About section of the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "about" , IsPrimaryKey = true)]
        public string About { get; set; }

        /// <summary>
        /// The access token you can use to act as the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "access_token" )]
        public string AccessToken { get; set; }

        /// <summary>
        /// Affiliation of this person. Applicable to Pages representing People
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "affiliation" )]
        public string Affiliation { get; set; }

        /// <summary>
        /// App ID for app-owned pages and app pages
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "app_id" )]
        public AppId AppId { get; set; }

        /// <summary>
        /// Artists the band likes. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "artists_we_like" )]
        public string ArtistsWeLike { get; set; }

        /// <summary>
        /// Dress code of the business. Applicable to Restaurants or Nightlife. Can be one of Casual, Dressy or Unspecified
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "attire" )]
        public string Attire { get; set; }

        /// <summary>
        /// The awards information of the film. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "awards" )]
        public string Awards { get; set; }

        /// <summary>
        /// Band interests. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "band_interests" )]
        public string BandInterests { get; set; }

        /// <summary>
        /// Members of the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "band_members" )]
        public string BandMembers { get; set; }

        /// <summary>
        /// Biography of the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "bio" )]
        public string Bio { get; set; }

        /// <summary>
        /// Birthday of this person. Applicable to Pages representing People
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "birthday" )]
        public string Birthday { get; set; }

        /// <summary>
        /// Booking agent of the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "booking_agent" )]
        public string BookingAgent { get; set; }

        /// <summary>
        /// The budget recommendations for a promoted post
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "budget_recs" )]
        public object BudgetRecs { get; set; }

        /// <summary>
        /// Built of the vehicle. Applicable to Vehicles
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "built" )]
        public string Built { get; set; }

        /// <summary>
        /// Indicates whether the current session user can post on this Page
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_post" )]
        public bool? CanPost { get; set; }

        /// <summary>
        /// The categories of the Page
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "categories" )]
        public object Categories { get; set; }

        /// <summary>
        /// Number of checkins at a place represented by a Page
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "checkins" )]
        public object Checkins { get; set; }

        /// <summary>
        /// The company overview. Applicable to Companies
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "company_overview" )]
        public string CompanyOverview { get; set; }

        /// <summary>
        /// Culinary team of the business. Applicable to Restaurants or Nightlife
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "culinary_team" )]
        public string CulinaryTeam { get; set; }

        /// <summary>
        /// Current location of the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "current_location" )]
        public string CurrentLocation { get; set; }

        /// <summary>
        /// The description of the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The description of the Page in raw HTML
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description_html" )]
        public string DescriptionHtml { get; set; }

        /// <summary>
        /// The director of the film. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "directed_by" )]
        public string DirectedBy { get; set; }

        /// <summary>
        /// The number of people who like the Page
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "fan_count" )]
        public object FanCount { get; set; }

        /// <summary>
        /// Features of the vehicle. Applicable to Vehicles
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "features" )]
        public string Features { get; set; }

        /// <summary>
        /// The restaurant's food styles. Applicable to Restaurants
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "food_styles" )]
        public object FoodStyles { get; set; }

        /// <summary>
        /// When the company is founded. Applicable to Companies
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "founded" )]
        public string Founded { get; set; }

        /// <summary>
        /// General information provided by the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "general_info" )]
        public string GeneralInfo { get; set; }

        /// <summary>
        /// General manager of the business. Applicable to Restaurants or Nightlife
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "general_manager" )]
        public string GeneralManager { get; set; }

        /// <summary>
        /// The genre of the film. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "genre" )]
        public string Genre { get; set; }

        /// <summary>
        /// The name of the Page with country codes appended for Global Brand Pages. Only viewable by the Page admin
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "global_brand_page_name" )]
        public string GlobalBrandPageName { get; set; }

        /// <summary>
        /// The id of this brand's global (parent) Page
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "global_brand_parent_page_id" )]
        public object GlobalBrandParentPageId { get; set; }

        /// <summary>
        /// Indicates whether this Page has added the app making the query in a Page tab
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "has_added_app" )]
        public bool? HasAddedApp { get; set; }

        /// <summary>
        /// Hometown of the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "hometown" )]
        public string Hometown { get; set; }

        /// <summary>
        /// Hours of operation. Applicable to Businesses and Places
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "hours" )]
        public object Hours { get; set; }

        /// <summary>
        /// Influences on the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "influences" )]
        public string Influences { get; set; }

        /// <summary>
        /// Indicates whether the Page is a community Page
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_community_page" )]
        public bool? IsCommunityPage { get; set; }

        /// <summary>
        /// Indicates whether the Page is published and visible to non-admins
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_published" )]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Keywords for the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "keywords" )]
        public string Keywords { get; set; }

        /// <summary>
        /// The location of this place. Applicable to all Places
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "location" )]
        public object Location { get; set; }

        /// <summary>
        /// Members of this org. Applicable to Pages representing Team Orgs
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "members" )]
        public string Members { get; set; }

        /// <summary>
        /// The company mission. Applicable to Companies
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "mission" )]
        public string Mission { get; set; }

        /// <summary>
        /// MPG of the vehicle. Applicable to Vehicles
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "mpg" )]
        public string Mpg { get; set; }

        /// <summary>
        /// The name of the Page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The TV network for the TV show. Applicable to TV Shows
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "network" )]
        public string Network { get; set; }

        /// <summary>
        /// The number of people who have liked the Page, since the last login. Only viewable by the page admin
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "new_like_count" )]
        public object NewLikeCount { get; set; }

        /// <summary>
        /// Offer eligibility status
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "offer_eligible" )]
        public bool? OfferEligible { get; set; }

        /// <summary>
        /// The ID of the Page.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "page_id" )]
        public PageId PageId { get; set; }

        /// <summary>
        /// The absolute URL to the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_url" )]
        public string PageUrl { get; set; }

        /// <summary>
        /// Parent Page for this Page
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "parent_page" )]
        public object ParentPage { get; set; }

        /// <summary>
        /// Parking information. Applicable to Businesses and Places. Can be one of street, lot or valet
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "parking" )]
        public object Parking { get; set; }

        /// <summary>
        /// Payment options accepted by the business. Applicable to Restaurants or Nightlife
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "payment_options" )]
        public object PaymentOptions { get; set; }

        /// <summary>
        /// Personal information. Applicable to Pages representing People
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "personal_info" )]
        public string PersonalInfo { get; set; }

        /// <summary>
        /// Personal interests. Applicable to Pages representing People
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "personal_interests" )]
        public string PersonalInterests { get; set; }

        /// <summary>
        /// Pharmacy safety information. Applicable to Pharmaceutical companies
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pharma_safety_info" )]
        public string PharmaSafetyInfo { get; set; }

        /// <summary>
        /// Phone number provided by a Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "phone" )]
        public string Phone { get; set; }

        /// <summary>
        /// The URL to the medium-sized profile picture for the Page. The image can have a maximum width of 100px and a maximum height of 300px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The URL to the large-sized profile picture for the Page. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// The JSON object containing three fields: cover_id (the ID of the cover photo), source (the URL for the cover photo), and offset_y (indicating percentage offset from top [0-100])
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "pic_cover" )]
        public object PicCover { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the Page. The image can have a maximum width of 396px and a maximum height of 1188px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_large" )]
        public string PicLarge { get; set; }

        /// <summary>
        /// The URL to the small-sized picture for the Page. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the Page. The image can have a maximum width and height of 50px. This URL may be blank
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// The plot outline of the film. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "plot_outline" )]
        public string PlotOutline { get; set; }

        /// <summary>
        /// Press contact information of the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "press_contact" )]
        public string PressContact { get; set; }

        /// <summary>
        /// Price range of the business. Applicable to Restaurants or Nightlife. Can be one of \$ (0-10), \$\$ (10-30), \$\$\$ (30-50), \$\$\$\$ (50+) or Unspecified
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "price_range" )]
        public string PriceRange { get; set; }

        /// <summary>
        /// The productor of the film. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "produced_by" )]
        public string ProducedBy { get; set; }

        /// <summary>
        /// The products of this company. Applicable to Companies
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "products" )]
        public string Products { get; set; }

        /// <summary>
        /// Boosted posts eligibility status
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "promotion_eligible" )]
        public bool? PromotionEligible { get; set; }

        /// <summary>
        /// Reason boosted posts not eligible
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "promotion_ineligible_reason" )]
        public string PromotionIneligibleReason { get; set; }

        /// <summary>
        /// Public transit to the business. Applicable to Restaurants or Nightlife
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "public_transit" )]
        public string PublicTransit { get; set; }

        /// <summary>
        /// Record label of the band. Applicable to Bands
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "record_label" )]
        public string RecordLabel { get; set; }

        /// <summary>
        /// The film's release data. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "release_date" )]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Services the restaurant provides. Applicable to Restaurants
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "restaurant_services" )]
        public object RestaurantServices { get; set; }

        /// <summary>
        /// The restaurant's specialties. Applicable to Restaurants
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "restaurant_specialties" )]
        public object RestaurantSpecialties { get; set; }

        /// <summary>
        /// The air schedule of the TV show. Applicable to TV Shows
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "schedule" )]
        public string Schedule { get; set; }

        /// <summary>
        /// The screenwriter of the film. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "screenplay_by" )]
        public string ScreenplayBy { get; set; }

        /// <summary>
        /// The season information of the TV Show. Applicable to TV Shows
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "season" )]
        public string Season { get; set; }

        /// <summary>
        /// The cast of the film. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "starring" )]
        public string Starring { get; set; }

        /// <summary>
        /// The studio for the film production. Applicable to Films
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "studio" )]
        public string Studio { get; set; }

        /// <summary>
        /// The count for the number of people Talking-about-this for the Page
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "talking_about_count" )]
        public object TalkingAboutCount { get; set; }

        /// <summary>
        /// The type of Page. e.g. Product/Service, Computers/Technology
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// Unread message count for the Page
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "unread_message_count" )]
        public object UnreadMessageCount { get; set; }

        /// <summary>
        /// Unseen message count for the Page
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "unseen_message_count" )]
        public object UnseenMessageCount { get; set; }

        /// <summary>
        /// Number of unseen notifications. Only viewable by the page admin
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "unseen_notif_count" )]
        public object UnseenNotifCount { get; set; }

        /// <summary>
        /// The alias of the Page, eg. For www.facebook.com/platform the username is 'platform'
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "username" )]
        public string Username { get; set; }

        /// <summary>
        /// The URL to the Web site of the Page
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website" )]
        public string Website { get; set; }

        /// <summary>
        /// The count for the number of visits for the Page
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "were_here_count" )]
        public object WereHereCount { get; set; }

        /// <summary>
        /// The writer of the TV show. Applicable to TV Shows
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "written_by" )]
        public string WrittenBy { get; set; }

    }
}
