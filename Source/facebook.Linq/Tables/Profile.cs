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
    /// http://developers.facebook.com/docs/reference/fql/profile/
    /// </summary>
    [Table(Name = "profile")]
    public class Profile
    {
        /// <summary>
        /// A 64-bit int representing the user, group, page, event, or application ID.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public long? Id { get; set; }

        /// <summary>
        /// Whether the current user can post to the objects profile wall.
        /// 
        /// original type is: boolean
        /// </summary>
        [Column(Name = "can_post" )]
        public bool? CanPost { get; set; }

        /// <summary>
        /// The full name of the object being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The URL to an object's profile or Page. If the object has a username, url contains the username.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" )]
        public string Url { get; set; }

        /// <summary>
        /// The URL to the small-sized profile picture for the object being queried. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The URL to the square profile picture for the object being queried. The image can have a maximum width and height of 50px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// The URL to the small-sized profile picture for the object being queried. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the object being queried. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// An object containing: uri: The URL to the largest-sized square profile picture for the object being queried. width, height: the pixel dimensions of this picture. left, top, right, bottom: the pixel co-ordinates of the user selected crop for this profile picture.
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "pic_crop" )]
        public JsonObject PicCrop { get; set; }

        /// <summary>
        /// The type of profile, one of user, group, page, event, or application.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "type" )]
        public string Type { get; set; }

        /// <summary>
        /// The username or alias of the object being queried.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "username" )]
        public string Username { get; set; }

    }
}
