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
    /// https://developers.facebook.com/docs/reference/fql/unified_thread_sync
    /// </summary>
    [Table(Name = "unified_thread_sync")]
    public class UnifiedThreadSync
    {
        /// <summary>
        /// Unique numeric version identifier for the thread. Guaranteed to increase as the thread is modified
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "action_id" , IsPrimaryKey = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// Fragment of the thread for admins to use in thread lists
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "admin_snippet" )]
        public string AdminSnippet { get; set; }

        /// <summary>
        /// Flag indicating whether the thread is archived
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "archived" )]
        public bool? Archived { get; set; }

        /// <summary>
        /// Auto mute settings for the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "auto_mute" )]
        public object AutoMute { get; set; }

        /// <summary>
        /// Whether the user can reply to the thread
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_reply" )]
        public bool? CanReply { get; set; }

        /// <summary>
        /// Folder name ('inbox', 'other' or 'spam')
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "folder" )]
        public string Folder { get; set; }

        /// <summary>
        /// List of former participants who have unsubscribed from the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "former_participants" )]
        public object FormerParticipants { get; set; }

        /// <summary>
        /// Whether the thread contains a message that has an attachment
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "has_attachments" )]
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// Whether the thread is a group conversation
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_group_conversation" )]
        public bool? IsGroupConversation { get; set; }

        /// <summary>
        /// Whether the thread is a named conversation
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_named_conversation" )]
        public bool? IsNamedConversation { get; set; }

        /// <summary>
        /// Whether the user is subscribed to the thread. Only applicable to threads with multiple participants where the user can leave the conversation
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_subscribed" )]
        public bool? IsSubscribed { get; set; }

        /// <summary>
        /// Version identifier corresponding to one of the following actions: new message in thread, new thread participant, participant left the thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_visible_add_action_id" )]
        public string LastVisibleAddActionId { get; set; }

        /// <summary>
        /// URL to the thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "link" )]
        public string Link { get; set; }

        /// <summary>
        /// Mute settings for the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "mute" )]
        public object Mute { get; set; }

        /// <summary>
        /// Name of the thread. Only applicable to threads with more than two participants
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// Total number of messages in the thread
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "num_messages" )]
        public object NumMessages { get; set; }

        /// <summary>
        /// Number of unread messages
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "num_unread" )]
        public object NumUnread { get; set; }

        /// <summary>
        /// List of participants which represent a Facebook page, group or event
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "object_participants" )]
        public object ObjectParticipants { get; set; }

        /// <summary>
        /// List of user participants who are currently subscribed to the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "participants" )]
        public object Participants { get; set; }

        /// <summary>
        /// Profile picture hash data for the thread participants
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_hash" )]
        public string PicHash { get; set; }

        /// <summary>
        /// Read receipts for the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "read_receipts" )]
        public object ReadReceipts { get; set; }

        /// <summary>
        /// ID of the refetch action
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "refetch_action_id" )]
        public string RefetchActionId { get; set; }

        /// <summary>
        /// List of participants who have sent a message in the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "senders" )]
        public object Senders { get; set; }

        /// <summary>
        /// User ID of the other thread participant for threads representing a two-person conversation
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "single_recipient" )]
        public Uid SingleRecipient { get; set; }

        /// <summary>
        /// Fragment of the thread for use in thread lists
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "snippet" )]
        public string Snippet { get; set; }

        /// <summary>
        /// Whether the snippet contains a message that has an attachment
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "snippet_message_has_attachment" )]
        public bool? SnippetMessageHasAttachment { get; set; }

        /// <summary>
        /// ID of the thread snippet
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "snippet_message_id" )]
        public ThreadId SnippetMessageId { get; set; }

        /// <summary>
        /// An object with properties of the sender
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "snippet_sender" )]
        public object SnippetSender { get; set; }

        /// <summary>
        /// Subject of the thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subject" )]
        public string Subject { get; set; }

        /// <summary>
        /// Change type for the synced thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sync_change_type" )]
        public string SyncChangeType { get; set; }

        /// <summary>
        /// List of tags in the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "tags" )]
        public object Tags { get; set; }

        /// <summary>
        /// Thread name, and names of of the user participants
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "thread_and_participants_name" )]
        public object ThreadAndParticipantsName { get; set; }

        /// <summary>
        /// FBID of the thread
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "thread_fbid" )]
        public ThreadId ThreadFbid { get; set; }

        /// <summary>
        /// ID of the thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" )]
        public ThreadId ThreadId { get; set; }

        /// <summary>
        /// List of participants who are currently subscribed to the thread
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "thread_participants" )]
        public object ThreadParticipants { get; set; }

        /// <summary>
        /// Last update time of the thread (UNIX timestamp, in milliseconds)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "timestamp" )]
        public string Timestamp { get; set; }

        /// <summary>
        /// The thread name, if it is defined, or the list of participants in the thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// Whether the thread contains unread messages
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "unread" )]
        public bool? Unread { get; set; }

        /// <summary>
        /// Whether the thread contains unseen messages
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "unseen" )]
        public bool? Unseen { get; set; }

    }
}
