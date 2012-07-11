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
    /// http://developers.facebook.com/docs/reference/fql/profile_tab/
    /// </summary>
    [Table(Name = "profile_view")]
    public class ProfileView
    {
        /// <summary>
        /// The ID of the Page.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "profile_id" , IsPrimaryKey = true)]
        public long? ProfileId { get; set; }

        /// <summary>
        /// The ID of the Page app.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "app_id" )]
        public long? AppId { get; set; }

        /// <summary>
        /// The permalink for the Page app.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// The URL for the Page apps icon.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "custom_image_url" )]
        public string CustomImageUrl { get; set; }

        /// <summary>
        /// The order of app as it is shown on the Page.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "position" )]
        public long? Position { get; set; }

        /// <summary>
        /// A flag to identify if the app can be removed from the Page (return false for default tabs).
        /// 
        /// original type is: boolean
        /// </summary>
        [Column(Name = "is_permanent" )]
        public bool? IsPermanent { get; set; }

    }
}
