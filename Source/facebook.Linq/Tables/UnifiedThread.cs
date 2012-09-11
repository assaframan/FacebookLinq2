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
    /// http://developers.facebook.com/docs/reference/fql/unified_thread/
    /// </summary>
    [Table(Name = "unified_thread")]
    public class UnifiedThread
    {
        /// <summary>
        /// Unique numeric version identifier for the thread. Guaranteed to increase as the thread is modified.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "action_id" , IsPrimaryKey = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// Flag indicating whether the thread is archived.
        /// 
        /// original type is: bool
        /// Indexable
        /// </summary>
        [Column(Name = "archived" )]
        public bool? Archived { get; set; }

        /// <summary>
        /// Flag indicating whether the user can reply to the thread.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_reply" )]
        public bool? CanReply { get; set; }

        /// <summary>
        /// Folder name (‘inbox’, ‘other’ or ‘spam’).
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "folder" )]
        public string Folder { get; set; }

        /// <summary>
        /// List of former participants who have unsubscribed from the thread. Each element of the list is an object with properties name (string), email (string) and user_id (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "former_participants" )]
        public JsonObject FormerParticipants { get; set; }

        /// <summary>
        /// Flag indicating whether the thread contains a message which includes an attachment.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "has_attachments" )]
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// Flag indicating whether user is subscribed to the thread. Only applicable to threads with multiple participants where user can leave the conversation.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_subscribed" )]
        public bool? IsSubscribed { get; set; }

        /// <summary>
        /// Version identifier corresponding to one of the following actions: new message in thread, new thread participant, participant left the thread.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_visible_add_action_id" )]
        public string LastVisibleAddActionId { get; set; }

        /// <summary>
        /// Name of the thread. Only applicable to threads with more than two participants.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// Total number of messages in the thread.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "num_messages" )]
        public long? NumMessages { get; set; }

        /// <summary>
        /// Number of unread messages.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "num_unread" )]
        public long? NumUnread { get; set; }

        /// <summary>
        /// List of participants who represent a Facebook page, group or event. Each element of the list is an object with properties object_address_type (int) and id (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "object_participants" )]
        public JsonObject ObjectParticipants { get; set; }

        /// <summary>
        /// List of participants who are currently subscribed to the thread. Each element of the list is an object with properties name (string), email (string) and user_id (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "participants" )]
        public JsonObject Participants { get; set; }

        /// <summary>
        /// List of participants who have sent a message in the thread. Each element of the list is an object with properties name (string), email (string) and user_id (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "senders" )]
        public JsonObject Senders { get; set; }

        /// <summary>
        /// For threads representing a two-person conversation this is the user ID of the other thread participant.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "single_recipient" )]
        public Uid SingleRecipient { get; set; }

        /// <summary>
        /// Fragment of the thread for use in thread lists.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "snippet" )]
        public string Snippet { get; set; }

        /// <summary>
        /// An object with properties name (string), email (string) and user_id (string) of the sender.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "snippet_sender" )]
        public JsonObject SnippetSender { get; set; }

        /// <summary>
        /// Flag indicating whether the thread contains a message which includes an attachment.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "snippet_message_has_attachment" )]
        public bool? SnippetMessageHasAttachment { get; set; }

        /// <summary>
        /// Subject of the thread.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subject" )]
        public Fid Subject { get; set; }

        /// <summary>
        /// Thread tags. See below.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tags" )]
        public JsonObject Tags { get; set; }

        /// <summary>
        /// Unique identifier of the thread.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "thread_id" )]
        public ThreadId ThreadId { get; set; }

        /// <summary>
        /// List of participants who are currently subscribed to the thread. Each element of the list is an object with properties name (string), email (string) and user_id (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "thread_participants" )]
        public JsonObject ThreadParticipants { get; set; }

        /// <summary>
        /// Last update time of the thread (Unix-type timestamp with millisecond resolution).
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "timestamp" )]
        public string Timestamp { get; set; }

        /// <summary>
        /// Flag indicating whether the thread contains unread messages.
        /// 
        /// original type is: bool
        /// Indexable
        /// </summary>
        [Column(Name = "unread" )]
        public bool? Unread { get; set; }

    }
}
