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
    /// https://developers.facebook.com/docs/reference/fql/group
    /// </summary>
    [Table(Name = "group")]
    public class Group
    {
        /// <summary>
        /// The user ID of the user who created the group being queried.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "creator" , IsPrimaryKey = true)]
        public Uid Creator { get; set; }

        /// <summary>
        /// The description of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The email address to upload content to the group being queried. Note that only an existing members of the group will be able to use this email address to upload content.)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "email" )]
        public string Email { get; set; }

        /// <summary>
        /// The group ID of the group being queried.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "gid" )]
        public GroupId Gid { get; set; }

        /// <summary>
        /// The URL of the bookmark icon for the group being queried. The maximum dimensions will be 16px height and 16px width.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon" )]
        public string Icon { get; set; }

        /// <summary>
        /// The URL of the bookmark icon for the group being queried. The maximum dimensions will be 34px height and 34px width. If a 34x34 size icon is unavailable this field will have the same value as icon)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon34" )]
        public string Icon34 { get; set; }

        /// <summary>
        /// The URL of the bookmark icon for the group being queried. The maximum dimensions will be 50px height and 50px width. If a 50x50 size icon is unavailable this field will have the same value as icon)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon50" )]
        public string Icon50 { get; set; }

        /// <summary>
        /// The URL of the bookmark icon for the group being queried. The maximum dimensions will be 68px height and 68px width. If a 68x68 size icon is unavailable this field will have the same value as icon)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon68" )]
        public string Icon68 { get; set; }

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
        /// original type is: number
        /// </summary>
        [Column(Name = "nid" )]
        public object Nid { get; set; }

        /// <summary>
        /// The location of the office of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "office" )]
        public string Office { get; set; }

        /// <summary>
        /// The parent id of the group.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "parent_id" )]
        public object ParentId { get; set; }

        /// <summary>
        /// The medium-sized photo for the group being queried. The image can have a maximum width of 100px and a maximum height of 300px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The largest-sized photo for the group being queried. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// The cover picture of the group.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "pic_cover" )]
        public object PicCover { get; set; }

        /// <summary>
        /// The URL to the smallest-sized photo for the group being queried. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the groupbeing queried. The image can have a maximum widdth of 50px and amaximum height of 50px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// The privacy setting of the group being queried, indicating whether the group is OPEN, CLOSED, or SECRET.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "privacy" )]
        public string Privacy { get; set; }

        /// <summary>
        /// The contents of the Recent News field of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "recent_news" )]
        public string RecentNews { get; set; }

        /// <summary>
        /// The last time the group being queried was updated.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "update_time" )]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The venue of the group being queried. This is an object containing street, city, state, country, zip, latitude, and longitude fields.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "venue" )]
        public Venue Venue { get; set; }

        /// <summary>
        /// The URL for the Web site of the group being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "website" )]
        public string Website { get; set; }

    }
}
