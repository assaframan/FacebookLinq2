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
    /// http://developers.facebook.com/docs/reference/fql/stream_tag/
    /// </summary>
    [Table(Name = "stream_tag")]
    public class StreamTag
    {
        /// <summary>
        /// The ID of a post from the user's or Page's stream. This field, when used as an index, is used to retrieve users and the entities they've tagged.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "post_id" , IsPrimaryKey = true)]
        public PostId PostId { get; set; }

        /// <summary>
        /// The user ID of the user or Page who tagged one or more entities in a post. This field, when used as an index, is used to retrieve all the posts and the entities the user has tagged.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "actor_id" )]
        public string ActorId { get; set; }

        /// <summary>
        /// The users, Pages, events, and other Facebook objects that have been tagged in one or more posts. This field, when used as an index, is used to retrieve all the entities that have been tagged in one or more posts.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "target_id" )]
        public string TargetId { get; set; }

    }
}
