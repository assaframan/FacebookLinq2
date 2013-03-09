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
    /// https://developers.facebook.com/docs/reference/fql/like
    /// </summary>
    [Table(Name = "like")]
    public class Like
    {
        /// <summary>
        /// The object_id of a video, note, link, photo, or album. Note: For photos and albums, the object_id is a different field from the <a href="/docs/reference/fql/photo">photo</a> table pid field and the <a href="/docs/reference/fql/album">album</a> table aid field, use the specified object_id from those tables instead.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "object_id" , IsPrimaryKey = true)]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// The type of the liked object. One of: photo, album, event, group, note, link, video, application, status, check-in, review, comment, post
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "object_type" )]
        public string ObjectType { get; set; }

        /// <summary>
        /// The id of a post on Facebook. This can be a stream post containing a status, video, note, link, photo, or photo album. Note: These post IDs must be queried from the <a href="/docs/reference/fql/stream">stream</a> FQL table.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "post_id" )]
        public PostId PostId { get; set; }

        /// <summary>
        /// The user who likes this object.Note: Indexable only for the current session user with read_stream permission.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "user_id" )]
        public object UserId { get; set; }

    }
}
