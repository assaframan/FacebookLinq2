using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/application/
    /// </summary>
    [Table(Name = "application")]
    public class Application
    {
        /// <summary>
        /// The ID of the application being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "app_id" , IsPrimaryKey = true)]
        public long AppId { get; set; }

        /// <summary>
        /// The API key of the application being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "api_key" )]
        public string ApiKey { get; set; }

        /// <summary>
        /// The string appended to apps.facebook.com/ to navigate to the application's canvas page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "namespace" )]
        public string Namespace { get; set; }

        /// <summary>
        /// The name of the application.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "display_name" )]
        public string DisplayName { get; set; }

        /// <summary>
        /// The URL identifying the application's icon image.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon_url" )]
        public string IconUrl { get; set; }

        /// <summary>
        /// The URL identifying the application's logo image.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "logo_url" )]
        public string LogoUrl { get; set; }

        /// <summary>
        /// The name of the company that built the application.<br /><strong>Note:</strong> Only one of company_name and developers will contain data, never both.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "company_name" )]
        public string CompanyName { get; set; }

        /// <summary>
        /// A list of records, where each record identifies a Facebook user who is marked as a developer of the application.<br /><strong>Note:</strong> Only one of company_name and developers will contain data, never both.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "developers" )]
        public string Developers { get; set; }

        /// <summary>
        /// The description of the application, as provided by the developer.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description " )]
        public string Description { get; set; }

        /// <summary>
        /// The number of Facebook users who've used the application in the last day.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "daily_active_users" )]
        public string DailyActiveUsers { get; set; }

        /// <summary>
        /// The number of Facebook users who've used the application in the last seven days.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "weekly_active_users" )]
        public string WeeklyActiveUsers { get; set; }

        /// <summary>
        /// The number of Facebook users who've used the application in the last 30 days.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "monthly_active_users" )]
        public string MonthlyActiveUsers { get; set; }

        /// <summary>
        /// The category the application can be found under.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "category" )]
        public string Category { get; set; }

        /// <summary>
        /// The subcategory the application can be found under.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subcategory" )]
        public string Subcategory { get; set; }

        /// <summary>
        /// Whether or not the application is natively developed by Facebook.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_facebook_app" )]
        public string IsFacebookApp { get; set; }

        /// <summary>
        /// Returns demographic restrictions for the app in a object with zero or more of the following fields: <code>type</code>, <code>location</code>, <code>age</code>, and <code>age_distr</code>. See <code>restrictions</code> field on the Graph API <a href="/docs/reference/api/application/">Application</a> object for more information.
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "restriction_info" )]
        public string RestrictionInfo { get; set; }

        /// <summary>
        /// Domains and subdomains this app can use. App <code>access_token</code> required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "app_domains" )]
        public string AppDomains { get; set; }

        /// <summary>
        /// The URL of a special landing page that helps users of an app begin publishing Open Graph activity. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_dialog_data_help_url" )]
        public string AuthDialogDataHelpUrl { get; set; }

        /// <summary>
        /// The description of an app that appears in the Auth Dialog. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_dialog_description" )]
        public string AuthDialogDescription { get; set; }

        /// <summary>
        /// One line description of an app that appears in the Auth Dialog. App <code>access_token</code> required; only returned if specifically requested via the fields URL parameter. <code>string</code>
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_dialog_headline" )]
        public string AuthDialogHeadline { get; set; }

        /// <summary>
        /// The text to explain why an app needs additional permissions that appears in the Auth Dialog. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_dialog_perms_explanation" )]
        public string AuthDialogPermsExplanation { get; set; }

        /// <summary>
        /// Basic user permissions that a user must grant when Authenticated Referrals are enabled. App <code>access_token</code> required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "auth_referral_user_perms" )]
        public string AuthReferralUserPerms { get; set; }

        /// <summary>
        /// Basic friends permissions that a user must grant when Authenticated Referrals are enabled. App <code>access_token</code> required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "auth_referral_friend_perms" )]
        public string AuthReferralFriendPerms { get; set; }

        /// <summary>
        /// The default privacy setting selected for Open Graph activities in the Auth Dialog. App <code>access_token</code> required; only returned if specifically requested via the fields URL parameter. <code>string</code> which is one of, <code>SELF</code>, <code>EVERYONE</code>, <code>ALL_FRIENDS</code> or <code>NONE</code>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_referral_default_activity_privacy" )]
        public string AuthReferralDefaultActivityPrivacy { get; set; }

        /// <summary>
        /// Indicates whether Authenticated Referrals are enabled. App <code>access_token</code> required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "auth_referral_enabled" )]
        public string AuthReferralEnabled { get; set; }

        /// <summary>
        /// Extended permissions that a user can choose to grant when Authenticated Referrals are enabled. App <code>access_token</code> required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "auth_referral_extended_perms" )]
        public string AuthReferralExtendedPerms { get; set; }

        /// <summary>
        /// The format that an app receives the Auth token from the Auth Dialog in. App <code>access_token</code> required; only returned if specifically requested via the fields URL parameter. <code>string</code> which is one of, <code>code</code> or <code>token</code>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_referral_response_type" )]
        public string AuthReferralResponseType { get; set; }

        /// <summary>
        /// Indicates whether app uses fluid or settable height values for Canvas. App <code>access_token</code> required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "canvas_fluid_height" )]
        public string CanvasFluidHeight { get; set; }

        /// <summary>
        /// Indicates whether app uses fluid or fixed width values for Canvas. App <code>access_token</code> required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "canvas_fluid_width" )]
        public string CanvasFluidWidth { get; set; }

        /// <summary>
        /// The non-secure URL from which Canvas app content is loaded. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "canvas_url" )]
        public string CanvasUrl { get; set; }

        /// <summary>
        /// Email address listed for users to contact developers. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "contact_email" )]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Unix timestamp that indicates when the app was created. App <code>access_token</code> required.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "created_time" )]
        public long CreatedTime { get; set; }

        /// <summary>
        /// User ID of the creator of this app. App <code>access_token</code> required.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "creator_uid" )]
        public long CreatorUid { get; set; }

        /// <summary>
        /// URL that is pinged whenever a user removes the app. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "deauth_callback_url" )]
        public string DeauthCallbackUrl { get; set; }

        /// <summary>
        /// ID of the app in the iPhone App Store. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "iphone_app_store_id" )]
        public string IphoneAppStoreId { get; set; }

        /// <summary>
        /// Webspace created with one of our hosting partners for this app. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "hosting_url" )]
        public string HostingUrl { get; set; }

        /// <summary>
        /// URL to which Mobile users will be directed when using the app. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "mobile_web_url" )]
        public string MobileWebUrl { get; set; }

        /// <summary>
        /// The title of the app when used in a Page Tab. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_tab_default_name" )]
        public string PageTabDefaultName { get; set; }

        /// <summary>
        /// The non-secure URL from which Page Tab app content is loaded. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_tab_url" )]
        public string PageTabUrl { get; set; }

        /// <summary>
        /// The URL that links to a Privacy Policy for the app. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "privacy_policy_url" )]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// The secure URL from which Canvas app content is loaded. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "secure_canvas_url" )]
        public string SecureCanvasUrl { get; set; }

        /// <summary>
        /// The secure URL from which Page Tab app content is loaded. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "secure_page_tab_url" )]
        public string SecurePageTabUrl { get; set; }

        /// <summary>
        /// App requests must originate from this comma-separated list of IP addresses. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "server_ip_whitelist" )]
        public string ServerIpWhitelist { get; set; }

        /// <summary>
        /// Indicates whether app usage stories show up in the Ticker or News Feed. App <code>access_token</code> required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "social_discovery" )]
        public string SocialDiscovery { get; set; }

        /// <summary>
        /// URL to Terms of Service which is linked to in Auth Dialog. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "terms_of_service_url" )]
        public string TermsOfServiceUrl { get; set; }

        /// <summary>
        /// App settings changes can only be made from an IP address in this comma-separated list. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "update_ip_whitelist" )]
        public string UpdateIpWhitelist { get; set; }

        /// <summary>
        /// Main contact email for this app. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "user_support_email" )]
        public string UserSupportEmail { get; set; }

        /// <summary>
        /// URL of support for users of an app shown in Canvas footer. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "user_support_url" )]
        public string UserSupportUrl { get; set; }

        /// <summary>
        /// URL of a website that integrates with this app. App <code>access_token</code> required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website_url" )]
        public string WebsiteUrl { get; set; }

    }
}
