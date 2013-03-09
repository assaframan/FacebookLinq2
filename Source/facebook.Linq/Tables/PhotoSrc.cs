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
    /// https://developers.facebook.com/docs/reference/fql/photo_src
    /// </summary>
    [Table(Name = "photo_src")]
    public class PhotoSrc
    {
        /// <summary>
        /// The height of the bounding box of the photo, in pixels. Note that this is not the height of the photo itself; please see the <a href="/docs/reference/fql/photo">photo</a> table for information on how to retrieve the dimensions of the photo itself
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "height" , IsPrimaryKey = true)]
        public object Height { get; set; }

        /// <summary>
        /// The ID of the photo being queried
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "photo_id" )]
        public PhotoId PhotoId { get; set; }

        /// <summary>
        /// A string representing the max size of the image returned. For example, 640X640. Note: If you want an exact dimension, use width and height
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "size" )]
        public string Size { get; set; }

        /// <summary>
        /// URL of the photo
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src" )]
        public string Src { get; set; }

        /// <summary>
        /// The width of the bounding box of the photo, in pixels. Note that this is not the width of the photo itself; please see the <a href="/docs/reference/fql/photo">photo</a> table for information on how to retrieve the dimensions of the photo itself
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "width" )]
        public object Width { get; set; }

    }
}
