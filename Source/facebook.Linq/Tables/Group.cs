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
    /// http://developers.facebook.com/docs/reference/fql/group/
    /// </summary>
    [Table(Name = "group")]
    public class Group
    {
        /// <summary>
        /// The group ID of the group being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "gid" , IsPrimaryKey = true)]
        public long? Gid { get; set; }

        /// <summary>
        /// The name of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The network ID for the network to which the group being queried belongs, if any.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "nid" )]
        public long? Nid { get; set; }

        /// <summary>
        /// The URL to the smallest-sized photo for the group being queried. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The largest-sized photo for the group being queried. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// The medium-sized photo for the group being queried. The image can have a maximum width of 100px and a maximum height of 300px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The description of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The category of the group being queried. This field has been DEPRECATED AND REMOVED and is no longer supported. Please see the deprecation <a href="https://developers.facebook.com/blog/post/2012/02/03/platform-updates--operation-developer-love/">announcement</a>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "group_type" )]
        public string GroupType { get; set; }

        /// <summary>
        /// The group type for the group being queried. This field has been DEPRECATED AND REMOVED and is no longer supported. Please see the deprecation <a href="https://developers.facebook.com/blog/post/2012/02/03/platform-updates--operation-developer-love/">announcement</a>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "group_subtype" )]
        public string GroupSubtype { get; set; }

        /// <summary>
        /// The contents of the Recent News field of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "recent_news" )]
        public string RecentNews { get; set; }

        /// <summary>
        /// The user ID of the user who created the group being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "creator" )]
        public long? Creator { get; set; }

        /// <summary>
        /// The last time the group being queried was updated.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "update_time" )]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The location of the office of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "office" )]
        public string Office { get; set; }

        /// <summary>
        /// The URL for the Web site of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website" )]
        public string Website { get; set; }

        /// <summary>
        /// The venue of the group being queried.  This is an object containing <code>street</code>, <code>city</code>, <code>state</code>, <code>country</code>, <code>zip</code>, <code>latitude</code>, and <code>longitude</code> fields.
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "venue" )]
        public JsonObject Venue { get; set; }

        /// <summary>
        /// The privacy setting of the group being queried, indicating whether the group is <code>OPEN</code>, <code>CLOSED</code>, or <code>SECRET</code>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "privacy" )]
        public string Privacy { get; set; }

        /// <summary>
        /// The URL of the bookmark icon for the group being queried. The maximum dimensions will be 16px height and 16px width.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon" )]
        public string Icon { get; set; }

        /// <summary>
        /// The URL of the bookmark icon for the group being queried. The maximum dimensions will be 34px height and 34px width. If a 34x34 size icon is unavailable this field will have the same value as <code>icon</code>)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon34" )]
        public string Icon34 { get; set; }

        /// <summary>
        /// The URL of the bookmark icon for the group being queried. The maximum dimensions will be 68px height and 68px width. If a 68x68 size icon is unavailable this field will have the same value as <code>icon</code>)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon68" )]
        public string Icon68 { get; set; }

        /// <summary>
        /// The email address to upload content to the group being queried. Note that only an existing members of the group will be able to use this email address to upload content.)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "email" )]
        public string Email { get; set; }

        /// <summary>
        /// The group version.  New groups are versioned > 0.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "version" )]
        public string Version { get; set; }

    }
}
