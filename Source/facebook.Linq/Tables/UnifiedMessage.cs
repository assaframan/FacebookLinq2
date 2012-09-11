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
        public MessageId MessageId { get; set; }

        /// <summary>
        /// Unique identifier of the thread.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" )]
        public ThreadId ThreadId { get; set; }

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
        /// Sender of the message. This field is an object with properties name (string), email (string) and user_id (string).
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "sender" )]
        public JsonObject Sender { get; set; }

        /// <summary>
        /// List of message recipients. Each element of the list is an object with properties name (string), email (string) and user_id (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "recipients" )]
        public UidsList Recipients { get; set; }

        /// <summary>
        /// Sender of the message in the case that it is a Facebook page, group or event. This field is an object with properties object_address_type (int) and id (string).
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
        /// Map from attachment identifiers to objects containing information about the attachment (file size, type, etc.). Each object has the following properties: id (string), type (int), mime_type (string), filename (string) and file_size (int).
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
        /// Map from share identifiers to objects containing information about the shared objects. Each object has the following properties: share_id (string), type (int), href (string), title (string), summary (string) and image (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "share_map" )]
        public JsonObject ShareMap { get; set; }

    }
}
