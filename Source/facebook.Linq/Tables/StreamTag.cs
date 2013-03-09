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
    /// https://developers.facebook.com/docs/reference/fql/stream_tag
    /// </summary>
    [Table(Name = "stream_tag")]
    public class StreamTag
    {
        /// <summary>
        /// The user ID of the user or Page who tagged one or more entities in a post
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "actor_id" , IsPrimaryKey = true)]
        public Uid ActorId { get; set; }

        /// <summary>
        /// The ID of a post from the user's or Page's stream
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "post_id" )]
        public PostId PostId { get; set; }

        /// <summary>
        /// The users, Pages, events, and other Facebook objects that have been tagged in one or more posts
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "target_id" )]
        public UnionId TargetId { get; set; }

    }
}
