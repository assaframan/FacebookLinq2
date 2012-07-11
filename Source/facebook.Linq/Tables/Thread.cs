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
    /// http://developers.facebook.com/docs/reference/fql/thread/
    /// </summary>
    [Table(Name = "thread")]
    public class Thread
    {
        /// <summary>
        /// The ID of the thread being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" , IsPrimaryKey = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// The ID of the folder that belongs to the thread you are querying. The ID can be one of: 0 (for Inbox), 1 (for Outbox), or 4 (for Updates).
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "folder_id" )]
        public string FolderId { get; set; }

        /// <summary>
        /// The subject of the thread.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "subject" )]
        public string Subject { get; set; }

        /// <summary>
        /// The user IDs of the recipients of the thread.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "recipients" )]
        public UidsList Recipients { get; set; }

        /// <summary>
        /// The created_time of the most recent message in the thread.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "updated_time" )]
        public long? UpdatedTime { get; set; }

        /// <summary>
        /// The ID of the message from which this thread was branched, or 0 if this thread is not a branch. The parent_message_id is a concatenation of the thread ID and the message ID, joined by an underscore.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "parent_message_id" )]
        public long? ParentMessageId { get; set; }

        /// <summary>
        /// The ID of the thread from which this thread was branched, or 0 if this thread is not a branch.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "parent_thread_id" )]
        public long? ParentThreadId { get; set; }

        /// <summary>
        /// The number of messages in this thread.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "message_count" )]
        public long? MessageCount { get; set; }

        /// <summary>
        /// A short bit of text from the most recent message.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "snippet" )]
        public string Snippet { get; set; }

        /// <summary>
        /// The user ID of the author of the snippet.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "snippet_author" )]
        public long? SnippetAuthor { get; set; }

        /// <summary>
        /// The object that sent this message, or 0 if it was not sent by an object. You can get more information about this object in the <strong>profile</strong> table.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "object_id" )]
        public long? ObjectId { get; set; }

        /// <summary>
        /// The number of unread messages in the thread.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "unread" )]
        public long? Unread { get; set; }

        /// <summary>
        /// The ID of the user whose Inbox you are querying.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "viewer_id" )]
        public string ViewerId { get; set; }

    }
}
