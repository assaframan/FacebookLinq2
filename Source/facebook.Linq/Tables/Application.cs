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
    /// https://developers.facebook.com/docs/reference/fql/application
    /// </summary>
    [Table(Name = "application")]
    public class Application
    {
        /// <summary>
        /// Android key hash of the app.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "android_key_hash" , IsPrimaryKey = true)]
        public object AndroidKeyHash { get; set; }

        /// <summary>
        /// The API key of the application being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "api_key" )]
        public string ApiKey { get; set; }

        /// <summary>
        /// Domains and subdomains this app can use. App access_token required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "app_domains" )]
        public AppDomains AppDomains { get; set; }

        /// <summary>
        /// The ID of the application being queried.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "app_id" )]
        public AppId AppId { get; set; }

        /// <summary>
        /// Name of the app.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "app_name" )]
        public string AppName { get; set; }

        /// <summary>
        /// Type of the app.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "app_type" )]
        public bool? AppType { get; set; }

        /// <summary>
        /// The URL identifying the hi-resolution version of the application's icon image
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "appcenter_icon_url" )]
        public string AppcenterIconUrl { get; set; }

        /// <summary>
        /// The URL of a special landing page that helps users of an app begin publishing Open Graph activity. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_dialog_data_help_url" )]
        public string AuthDialogDataHelpUrl { get; set; }

        /// <summary>
        /// One line description of an app that appears in the Auth Dialog. App access_token required; only returned if specifically requested via the fields URL parameter. string
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_dialog_headline" )]
        public string AuthDialogHeadline { get; set; }

        /// <summary>
        /// The text to explain why an app needs additional permissions that appears in the Auth Dialog. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_dialog_perms_explanation" )]
        public string AuthDialogPermsExplanation { get; set; }

        /// <summary>
        /// The default privacy setting selected for Open Graph activities in the Auth Dialog. App access_token required; only returned if specifically requested via the fields URL parameter. string which is one of, SELF, EVERYONE, ALL_FRIENDS or NONE.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_referral_default_activity_privacy" )]
        public string AuthReferralDefaultActivityPrivacy { get; set; }

        /// <summary>
        /// Indicates whether Authenticated Referrals are enabled. App access_token required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "auth_referral_enabled" )]
        public bool? AuthReferralEnabled { get; set; }

        /// <summary>
        /// Extended permissions that a user can choose to grant when Authenticated Referrals are enabled. App access_token required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "auth_referral_extended_perms" )]
        public Auths AuthReferralExtendedPerms { get; set; }

        /// <summary>
        /// Basic friends permissions that a user must grant when Authenticated Referrals are enabled. App access_token required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "auth_referral_friend_perms" )]
        public Auths AuthReferralFriendPerms { get; set; }

        /// <summary>
        /// The format that an app receives the Auth token from the Auth Dialog in. App access_token required; only returned if specifically requested via the fields URL parameter. string which is one of, code or token.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "auth_referral_response_type" )]
        public string AuthReferralResponseType { get; set; }

        /// <summary>
        /// Basic user permissions that a user must grant when Authenticated Referrals are enabled. App access_token required.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "auth_referral_user_perms" )]
        public Auths AuthReferralUserPerms { get; set; }

        /// <summary>
        /// Indicates whether app uses fluid or settable height values for Canvas. App access_token required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "canvas_fluid_height" )]
        public bool? CanvasFluidHeight { get; set; }

        /// <summary>
        /// Indicates whether app uses fluid or fixed width values for Canvas. App access_token required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "canvas_fluid_width" )]
        public bool? CanvasFluidWidth { get; set; }

        /// <summary>
        /// The non-secure URL from which Canvas app content is loaded. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "canvas_url" )]
        public string CanvasUrl { get; set; }

        /// <summary>
        /// The category the application can be found under.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "category" )]
        public string Category { get; set; }

        /// <summary>
        /// Config data for the client
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "client_config" )]
        public object ClientConfig { get; set; }

        /// <summary>
        /// The name of the company that built the application. Note: Only one of company_name and developers will contain data, never both.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "company_name" )]
        public string CompanyName { get; set; }

        /// <summary>
        /// True if the app has configured Single Sign On on iOS
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "configured_ios_sso" )]
        public bool? ConfiguredIosSso { get; set; }

        /// <summary>
        /// Email address listed for users to contact developers. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "contact_email" )]
        public string ContactEmail { get; set; }

        /// <summary>
        /// UNIX timestamp that indicates when the app was created. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// User ID of the creator of this app. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "creator_uid" )]
        public Uid CreatorUid { get; set; }

        /// <summary>
        /// The number of Facebook users who've used the application in the last day.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "daily_active_users" )]
        public object DailyActiveUsers { get; set; }

        /// <summary>
        /// URL that is pinged whenever a user removes the app. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "deauth_callback_url" )]
        public string DeauthCallbackUrl { get; set; }

        /// <summary>
        /// The description of the application, as provided by the developer.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// A list of records, where each record identifies a Facebook user who is marked as a developer of the application. Note: Only one of company_name and developers will contain data, never both.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "developers" )]
        public Developers Developers { get; set; }

        /// <summary>
        /// The name of the application.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "display_name" )]
        public string DisplayName { get; set; }

        /// <summary>
        /// Webspace created with one of our hosting partners for this app. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "hosting_url" )]
        public string HostingUrl { get; set; }

        /// <summary>
        /// The URL identifying the application's icon image.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon_url" )]
        public string IconUrl { get; set; }

        /// <summary>
        /// Bundle ID of the associated iOS app.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "ios_bundle_id" )]
        public object IosBundleId { get; set; }

        /// <summary>
        /// ID of the app in the iPad App Store. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "ipad_app_store_id" )]
        public AppId IpadAppStoreId { get; set; }

        /// <summary>
        /// ID of the app in the iPhone App Store. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "iphone_app_store_id" )]
        public AppId IphoneAppStoreId { get; set; }

        /// <summary>
        /// Whether or not the application is natively developed by Facebook.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_facebook_app" )]
        public bool? IsFacebookApp { get; set; }

        /// <summary>
        /// Facebook profile link of the app.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// The URL identifying the application's logo image.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "logo_url" )]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Status of every valid migration for this app (true means enabled.)
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "migration_status" )]
        public object MigrationStatus { get; set; }

        /// <summary>
        /// URL of the app section on a user's profile for the mobile site.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "mobile_profile_section_url" )]
        public string MobileProfileSectionUrl { get; set; }

        /// <summary>
        /// URL to which Mobile users will be directed when using the app. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "mobile_web_url" )]
        public string MobileWebUrl { get; set; }

        /// <summary>
        /// The number of Facebook users who've used the application in the last 30 days.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "monthly_active_users" )]
        public object MonthlyActiveUsers { get; set; }

        /// <summary>
        /// The string appended to apps.facebook.com/ to navigate to the application's canvas page.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "namespace" )]
        public string Namespace { get; set; }

        /// <summary>
        /// The title of the app when used in a Page Tab. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_tab_default_name" )]
        public string PageTabDefaultName { get; set; }

        /// <summary>
        /// The non-secure URL from which Page Tab app content is loaded. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "page_tab_url" )]
        public string PageTabUrl { get; set; }

        /// <summary>
        /// The URL that links to a Privacy Policy for the app. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "privacy_policy_url" )]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// URL of the app section on a user's profile for the desktop site.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "profile_section_url" )]
        public string ProfileSectionUrl { get; set; }

        /// <summary>
        /// Returns demographic restrictions for the app in a object with zero or more of the following fields: type, location, age, and age_distr. See restrictions field on the Graph API <a href="/docs/reference/api/application/">Application</a> object for more information.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "restriction_info" )]
        public object RestrictionInfo { get; set; }

        /// <summary>
        /// The secure URL from which Canvas app content is loaded. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "secure_canvas_url" )]
        public string SecureCanvasUrl { get; set; }

        /// <summary>
        /// The secure URL from which Page Tab app content is loaded. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "secure_page_tab_url" )]
        public string SecurePageTabUrl { get; set; }

        /// <summary>
        /// Indicates whether app usage stories show up in the Ticker or News Feed. App access_token required.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "social_discovery" )]
        public bool? SocialDiscovery { get; set; }

        /// <summary>
        /// The subcategory the application can be found under.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subcategory" )]
        public string Subcategory { get; set; }

        /// <summary>
        /// Indicates whether the app has opted out of app install tracking.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "supports_attribution" )]
        public bool? SupportsAttribution { get; set; }

        /// <summary>
        /// Indicates whether the app has opted out of the mobile SDKs sending data on SDK interactions.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "supports_implicit_sdk_logging" )]
        public bool? SupportsImplicitSdkLogging { get; set; }

        /// <summary>
        /// URL to Terms of Service which is linked to in Auth Dialog. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "terms_of_service_url" )]
        public string TermsOfServiceUrl { get; set; }

        /// <summary>
        /// ><p>
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url_scheme_suffix" )]
        public string UrlSchemeSuffix { get; set; }

        /// <summary>
        /// Main contact email for this app. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "user_support_email" )]
        public string UserSupportEmail { get; set; }

        /// <summary>
        /// URL of support for users of an app shown in Canvas footer. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "user_support_url" )]
        public string UserSupportUrl { get; set; }

        /// <summary>
        /// URL of a website that integrates with this app. App access_token required.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website_url" )]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The number of Facebook users who've used the application in the last seven days.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "weekly_active_users" )]
        public object WeeklyActiveUsers { get; set; }

    }
}
