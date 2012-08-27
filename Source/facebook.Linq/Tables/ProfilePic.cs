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
    /// http://developers.facebook.com/docs/reference/fql/profile_pic/
    /// </summary>
    [Table(Name = "profile_pic")]
    public class ProfilePic
    {
        /// <summary>
        /// ID of the user
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public long? Id { get; set; }

        /// <summary>
        /// requested width of the profile pic, in pixels
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "width" )]
        public long? Width { get; set; }

        /// <summary>
        /// requested height of the profile pic, in pixels
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "height" )]
        public long? Height { get; set; }

        /// <summary>
        /// URL pointing to the returned picture
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" )]
        public string Url { get; set; }

        /// <summary>
        /// This value is <code>true</code> if a profile picture has not been set (i.e. the profile picture is the default picture)
        /// 
        /// original type is: boolean
        /// </summary>
        [Column(Name = "is_silhouette" )]
        public bool? IsSilhouette { get; set; }

        /// <summary>
        /// actual width of the returned profile pic, in pixels (this may or may not be the same as <code>width</code>)
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "real_width" )]
        public long? RealWidth { get; set; }

        /// <summary>
        /// actual height of the returned profile pic, in pixels (this may or may not be the same as <code>height</code>)
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "real_height" )]
        public long? RealHeight { get; set; }

    }
}
