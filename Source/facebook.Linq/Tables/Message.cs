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
    /// http://developers.facebook.com/docs/reference/fql/message/
    /// </summary>
    [Table(Name = "message")]
    public class Message
    {
        /// <summary>
        /// A unique ID for the message being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message_id" , IsPrimaryKey = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// The ID of the thread the message belongs to.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" )]
        public string ThreadId { get; set; }

        /// <summary>
        /// The ID of the user who wrote this message.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "author_id" )]
        public long AuthorId { get; set; }

        /// <summary>
        /// The content of the message.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "body" )]
        public string Body { get; set; }

        /// <summary>
        /// The time the message was sent (represented as a unix timestamp)
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "created_time" )]
        public long CreatedTime { get; set; }

        /// <summary>
        /// An array of information about the attachment to the message. This is the attachment that Facebook returns.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "attachment" )]
        public JsonObject Attachment { get; set; }

        /// <summary>
        /// The ID of the user whose Inbox you are querying. Defaults to session user.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "viewer_id" )]
        public string ViewerId { get; set; }

    }
}
