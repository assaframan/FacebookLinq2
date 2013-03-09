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
    /// https://developers.facebook.com/docs/reference/fql/unified_message_sync
    /// </summary>
    [Table(Name = "unified_message_sync")]
    public class UnifiedMessageSync
    {
        /// <summary>
        /// Version ID that increases in the same order as messages are received by Facebook. If messages arrive out of order, this ordering can theoretically be different from the timestamp-based ordering, since timestamps for email-originated messages are based on the timestamp of the sender's email client
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "action_id" , IsPrimaryKey = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// Map from attachment IDs to objects containing information about the attachment (file size, type, etc.)
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "attachment_map" )]
        public object AttachmentMap { get; set; }

        /// <summary>
        /// List of attachment IDs. Attachments correspond to any attached file
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "attachments" )]
        public object Attachments { get; set; }

        /// <summary>
        /// Body of the message
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "body" )]
        public string Body { get; set; }

        /// <summary>
        /// ID of the parent message
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "containing_message_id" )]
        public string ContainingMessageId { get; set; }

        /// <summary>
        /// Coordinates of the location associated with this message
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "coordinates" )]
        public object Coordinates { get; set; }

        /// <summary>
        /// ID of the forwarded message
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "forwarded_message_id" )]
        public string ForwardedMessageId { get; set; }

        /// <summary>
        /// Forwarded messages
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "forwarded_messages" )]
        public object ForwardedMessages { get; set; }

        /// <summary>
        /// HTML representation of the message body
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "html_body" )]
        public string HtmlBody { get; set; }

        /// <summary>
        /// Whether the message is forwarded
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_forwarded" )]
        public bool? IsForwarded { get; set; }

        /// <summary>
        /// Whether the log message has a user-generated body
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_user_generated" )]
        public bool? IsUserGenerated { get; set; }

        /// <summary>
        /// The log message associated with this message
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "log_message" )]
        public object LogMessage { get; set; }

        /// <summary>
        /// ID of the message
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message_id" )]
        public MessageId MessageId { get; set; }

        /// <summary>
        /// Sender of the message in the case that it is a Facebook page, group or event
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "object_sender" )]
        public object ObjectSender { get; set; }

        /// <summary>
        /// Client provided message ID that clients like Facebook Messenger can use to associated a unique ID with the message being sent
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "offline_threading_id" )]
        public string OfflineThreadingId { get; set; }

        /// <summary>
        /// List of message recipients
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "recipients" )]
        public UidsList Recipients { get; set; }

        /// <summary>
        /// Sender of the message
        /// 
        /// original type is: (null) or (struct with keys: name, email, user_id)
        /// </summary>
        [Column(Name = "sender" )]
        public object Sender { get; set; }

        /// <summary>
        /// Map from share IDs to objects containing information about the shared objects
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "share_map" )]
        public object ShareMap { get; set; }

        /// <summary>
        /// List of share IDs. Shared items include links, videos, and photos as were supported in the old messaging system
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "shares" )]
        public object Shares { get; set; }

        /// <summary>
        /// Subject of the message
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subject" )]
        public string Subject { get; set; }

        /// <summary>
        /// Information on whether the message was added or deleted
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sync_change_type" )]
        public string SyncChangeType { get; set; }

        /// <summary>
        /// List of users tagged in the message
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tags" )]
        public object Tags { get; set; }

        /// <summary>
        /// ID of the thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" )]
        public ThreadId ThreadId { get; set; }

        /// <summary>
        /// Last update time of the thread (UNIX timestamp)
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "timestamp" )]
        public object Timestamp { get; set; }

        /// <summary>
        /// Whether the message is unread
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "unread" )]
        public bool? Unread { get; set; }

    }
}
