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
    /// http://developers.facebook.com/docs/reference/fql/photo_src/
    /// </summary>
    [Table(Name = "photo_src")]
    public class PhotoSrc
    {
        /// <summary>
        /// The id of the photo being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "photo_id" , IsPrimaryKey = true)]
        public long? PhotoId { get; set; }

        /// <summary>
        /// A string representing max size of the image returned. For example, 640X640. <strong>Note:</strong> If you want an exact dimension, use width and height.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "size" )]
        public string Size { get; set; }

        /// <summary>
        /// The width of the bounding box of the photo, in pixels. Note that this is not the width of the photo itself; please see the <a href="/docs/reference/fql/photo">photo</a> table for information on how to retrieve the dimensions of the photo itself.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "width" )]
        public long? Width { get; set; }

        /// <summary>
        /// The height of the bounding box of the photo, in pixels. Note that this is not the height of the photo itself; please see the <a href="/docs/reference/fql/photo">photo</a> table for information on how to retrieve the dimensions of the photo itself.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "height" )]
        public long? Height { get; set; }

        /// <summary>
        /// URL of the photo.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "src" )]
        public string Src { get; set; }

    }
}
