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
    /// http://developers.facebook.com/docs/reference/fql/stream/
    /// </summary>
    [Table(Name = "stream")]
    public class Stream
    {
        /// <summary>
        /// The ID of the post
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "post_id" , IsPrimaryKey = true)]
        public string PostId { get; set; }

        /// <summary>
        /// The ID of the current session user
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "viewer_id " )]
        public long? ViewerId { get; set; }

        /// <summary>
        /// For posts published by apps, the ID of that app
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "app_id" )]
        public long? AppId { get; set; }

        /// <summary>
        /// The ID of the user, page, group, or event whose wall the post is on
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "source_id " )]
        public long? SourceId { get; set; }

        /// <summary>
        /// The time the post was last updated, which occurs when a user comments on the post, expressed as a Unix timestamp. Querying by <code>updated_time</code> is currently not supported
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The time the post was published, expressed as a Unix timestamp
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The filter key to fetch data with. This key should be retrieved from by querying the stream_filter FQL table or with the special values 'others' or 'owner'.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "filter_key" )]
        public string FilterKey { get; set; }

        /// <summary>
        /// For posts published by apps, the full name of that app
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "attribution " )]
        public string Attribution { get; set; }

        /// <summary>
        /// The ID of the user, page, group, or event that published the post
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "actor_id" )]
        public string ActorId { get; set; }

        /// <summary>
        /// The user, page, group, or event to whom the post was directed
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "target_id" )]
        public string TargetId { get; set; }

        /// <summary>
        /// The message written in the post
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// An array of app specific information optionally supplied to create the attachment to the post
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "app_data" )]
        public JsonObject AppData { get; set; }

        /// <summary>
        /// An array containing the text and URL for each action link
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "action_links" )]
        public JsonObject ActionLinks { get; set; }

        /// <summary>
        /// An array of information about the attachment to the post. This is the attachment that Facebook returns
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "attachment" )]
        public JsonObject Attachment { get; set; }

        /// <summary>
        /// Number of impressions of this post. This data is visible only if you have <a href="/docs/authentication/permissions/"><code>read_insights</code></a> permission from a page owner
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "impressions" )]
        public long? Impressions { get; set; }

        /// <summary>
        /// An array containing the following information about comments for a post:
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "comments" )]
        public JsonObject Comments { get; set; }

        /// <summary>
        /// An array containing the following information about likes for the post:
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "likes" )]
        public JsonObject Likes { get; set; }

        /// <summary>
        /// Facebook ID of the place associated with the post, if any
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "place" )]
        public long? Place { get; set; }

        /// <summary>
        /// The privacy settings for a post
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "privacy" )]
        public JsonObject Privacy { get; set; }

        /// <summary>
        /// A link to the stream post on Facebook
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "permalink" )]
        public string Permalink { get; set; }

        /// <summary>
        /// When querying for the feed of a live stream box, this is the xid associated with the Live Stream box (you can provide 'default' if one is not available)
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "xid" )]
        public long? Xid { get; set; }

        /// <summary>
        /// An array of IDs tagged in the <code>message</code> of the post.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tagged_ids" )]
        public JsonObject TaggedIds { get; set; }

        /// <summary>
        /// An array indexed by offset of arrays of the tags in the <code>message</code> of the post, containing the <code>id</code> of the tagged object, the <code>name</code> of the tag, the <code>offset</code> of where the tag occurs in the message and the <code>length</code> of the tag.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "message_tags" )]
        public JsonObject MessageTags { get; set; }

        /// <summary>
        /// Text of stories not intentionally generated by users, such as those generated when two users become friends; you must have the "Include recent activity stories" migration enabled in your app to retrieve this field.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// An array indexed by offset of arrays of the tags in the <code>description</code> of the post, containing the <code>id</code> of the tagged object, the <code>name</code> of the tag, the <code>offset</code> of where the tag occurs in the message and the <code>length</code> of the tag; You must have the "Include recent activity stories" migration enabled in your app to retrieve this field.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "description_tags" )]
        public JsonObject DescriptionTags { get; set; }

        /// <summary>
        /// The type of this story. Possible values are:
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "type" )]
        public long? Type { get; set; }

    }
}
