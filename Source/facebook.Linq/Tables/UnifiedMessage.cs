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
    /// http://developers.facebook.com/docs/reference/fql/unified_message/
    /// </summary>
    [Table(Name = "unified_message")]
    public class UnifiedMessage
    {
        /// <summary>
        /// Unique identifier of the message.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message_id" , IsPrimaryKey = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Unique identifier of the thread.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" )]
        public string ThreadId { get; set; }

        /// <summary>
        /// Subject of the message.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subject" )]
        public string Subject { get; set; }

        /// <summary>
        /// Body of the message.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "body" )]
        public string Body { get; set; }

        /// <summary>
        /// Flag indicating whether the message is unread.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "unread" )]
        public bool? Unread { get; set; }

        /// <summary>
        /// Unique version identifier that increases in the same order as messages are received by Facebook. If messages arrive out of order, this ordering can theoretically be different from the timestamp-based ordering, since timestamps for email-originated messages are based on the timestamp of the sender's email client.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "action_id" )]
        public string ActionId { get; set; }

        /// <summary>
        /// Last update time of the thread (Unix-type timestamp with millisecond resolution).
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "timestamp" )]
        public string Timestamp { get; set; }

        /// <summary>
        /// Message tags.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tags" )]
        public JsonObject Tags { get; set; }

        /// <summary>
        /// Sender of the message. This field is an object with properties <code>name</code> (string), <code>email</code> (string) and <code>user_id</code> (string).
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "sender" )]
        public JsonObject Sender { get; set; }

        /// <summary>
        /// List of message recipients. Each element of the list is an object with properties <code>name</code> (string), <code>email</code> (string) and <code>user_id</code> (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "recipients" )]
        public UidsList Recipients { get; set; }

        /// <summary>
        /// Sender of the message in the case that it is a Facebook page, group or event. This field is an object with properties <code>object_address_type</code> (int) and <code>id</code> (string).
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "object_sender" )]
        public JsonObject ObjectSender { get; set; }

        /// <summary>
        /// HTML representation of the message body.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "html_body" )]
        public string HtmlBody { get; set; }

        /// <summary>
        /// List of attachment identifiers.  Attachments correspond to any attached file.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "attachments" )]
        public JsonObject Attachments { get; set; }

        /// <summary>
        /// Map from attachment identifiers to objects containing information about the attachment (file size, type, etc.). Each object has the following properties: <code>id</code> (string), <code>type</code> (int), <code>mime_type</code> (string), <code>filename</code> (string) and <code>file_size</code> (int).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "attachment_map" )]
        public JsonObject AttachmentMap { get; set; }

        /// <summary>
        /// List of share identifiers.  Shared items include links, videos, and photos as were supported in the old messaging system.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "shares" )]
        public JsonObject Shares { get; set; }

        /// <summary>
        /// Map from share identifiers to objects containing information about the shared objects. Each object has the following properties: <code>share_id</code> (string), <code>type</code> (int), <code>href</code> (string), <code>title</code> (string), <code>summary</code> (string) and <code>image</code> (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "share_map" )]
        public JsonObject ShareMap { get; set; }

    }
}
