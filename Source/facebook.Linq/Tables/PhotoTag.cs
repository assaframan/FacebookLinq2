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
    /// https://developers.facebook.com/docs/reference/fql/photo_tag
    /// </summary>
    [Table(Name = "photo_tag")]
    public class PhotoTag
    {
        /// <summary>
        /// The date that the tag being queried was created (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created" , IsPrimaryKey = true)]
        public object Created { get; set; }

        /// <summary>
        /// The object ID of the photo being queried. Preferred over pid
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "object_id" )]
        public PhotoId ObjectId { get; set; }

        /// <summary>
        /// The ID of the photo being queried. The pid cannot be longer than 50 characters. Note: Because the pid is a string, you should always wrap the pid in quotes when referenced in a query
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pid" )]
        public PhotoId Pid { get; set; }

        /// <summary>
        /// The ID of the object that is tagged, e.g. user, group, and event. For photos associated with events or groups, use the eid or gid for subject
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subject" )]
        public ObjectId Subject { get; set; }

        /// <summary>
        /// The content of the tag being queried. It contains either the name of the user tagged or the text tag
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "text" )]
        public string Text { get; set; }

        /// <summary>
        /// The center of the tag's horizontal position, measured as a floating-point percentage from 0 to 100, from the left edge of the photo
        /// 
        /// original type is: float
        /// </summary>
        [Column(Name = "xcoord" )]
        public float? Xcoord { get; set; }

        /// <summary>
        /// The center of the tag's vertical position, measured as a floating-point percentage from 0 to 100, from the top edge of the photo
        /// 
        /// original type is: float
        /// </summary>
        [Column(Name = "ycoord" )]
        public float? Ycoord { get; set; }

    }
}
