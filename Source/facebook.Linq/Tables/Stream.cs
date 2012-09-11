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
        /// Indexable
        /// </summary>
        [Column(Name = "post_id" , IsPrimaryKey = true)]
        public PostId PostId { get; set; }

        /// <summary>
        /// The ID of the current session user
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "viewer_id" )]
        public Uid ViewerId { get; set; }

        /// <summary>
        /// For posts published by apps, the ID of that app. If the value is empty, it indicates a Facebook feature generated the post
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "app_id" )]
        public AppId AppId { get; set; }

        /// <summary>
        /// The ID of the user, page, group, or event whose wall the post is on
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "source_id" )]
        public Fid SourceId { get; set; }

        /// <summary>
        /// The time the post was last updated, which occurs when a user comments on the post, expressed as a Unix timestamp. Querying by updated_time is currently not supported
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
        /// Indexable
        /// </summary>
        [Column(Name = "filter_key" )]
        public string FilterKey { get; set; }

        /// <summary>
        /// For posts published by apps, the full name of that app
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "attribution" )]
        public string Attribution { get; set; }

        /// <summary>
        /// The ID of the user, page, group, or event that published the post
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "actor_id" )]
        public Fid ActorId { get; set; }

        /// <summary>
        /// The user, page, group, or event to whom the post was directed
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "target_id" )]
        public Fid TargetId { get; set; }

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
        public object AppData { get; set; }

        /// <summary>
        /// An array containing the text and URL for each action link
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "action_links" )]
        public object ActionLinks { get; set; }

        /// <summary>
        /// An array of information about the attachment to the post. This is the attachment that Facebook returns
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "attachment" )]
        public object Attachment { get; set; }

        /// <summary>
        /// Number of impressions of this post. This data is visible only if you have <a href="/docs/authentication/permissions/">read_insights</a> permission from a page owner
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
        public object Comments { get; set; }

        /// <summary>
        /// An array containing the following information about likes for the post:
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "likes" )]
        public object Likes { get; set; }

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
        public object Privacy { get; set; }

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
        /// Indexable
        /// </summary>
        [Column(Name = "xid" )]
        public Xid Xid { get; set; }

        /// <summary>
        /// An array of IDs tagged in the message of the post.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tagged_ids" )]
        public object TaggedIds { get; set; }

        /// <summary>
        /// An array indexed by offset of arrays of the tags in the message of the post, containing the id of the tagged object, the name of the tag, the offset of where the tag occurs in the message and the length of the tag.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "message_tags" )]
        public Tags MessageTags { get; set; }

        /// <summary>
        /// Text of stories not intentionally generated by users, such as those generated when two users become friends; you must have the "Include recent activity stories" migration enabled in your app to retrieve this field.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// An array indexed by offset of arrays of the tags in the description of the post, containing the id of the tagged object, the name of the tag, the offset of where the tag occurs in the message and the length of the tag; You must have the "Include recent activity stories" migration enabled in your app to retrieve this field.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "description_tags" )]
        public Tags DescriptionTags { get; set; }

        /// <summary>
        /// The type of this story. Possible values are:
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "type" )]
        public StreamType Type { get; set; }

    }
}
