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
    /// https://developers.facebook.com/docs/reference/fql/unified_message_count
    /// </summary>
    [Table(Name = "unified_message_count")]
    public class UnifiedMessageCount
    {
        /// <summary>
        /// Folder name ('inbox', 'other' or 'spam')
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "folder" , IsPrimaryKey = true)]
        public string Folder { get; set; }

        /// <summary>
        /// The highest action ID of a thread in a particular folder. The value increases as new messages are added. This can be useful for checking whether there are any new threads in the folder
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_action_id" )]
        public string LastActionId { get; set; }

        /// <summary>
        /// Last time the folder was accessed (UNIX timestamp, in milliseconds)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "last_seen_time" )]
        public DateTime? LastSeenTime { get; set; }

        /// <summary>
        /// Refetch action ID of a thread in a particular folder. If your cached action ID is lower than this value, you should do a full refetch instead of syncing incrementally via unified_thread_sync
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "refetch_action_id" )]
        public string RefetchActionId { get; set; }

        /// <summary>
        /// Total number of non-archived threads
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "total_threads" )]
        public object TotalThreads { get; set; }

        /// <summary>
        /// Number of unread threads in the folder
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "unread_count" )]
        public object UnreadCount { get; set; }

        /// <summary>
        /// Number of unseen threads in the folder
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "unseen_count" )]
        public object UnseenCount { get; set; }

    }
}
