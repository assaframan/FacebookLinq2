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
    /// http://developers.facebook.com/docs/reference/fql/unified_thread_count/
    /// </summary>
    [Table(Name = "unified_thread_count")]
    public class UnifiedThreadCount
    {
        /// <summary>
        /// Folder name (‘inbox’, ‘other’ or ‘spam’).
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "folder" , IsPrimaryKey = true)]
        public string Folder { get; set; }

        /// <summary>
        /// Number of unread threads in the folder.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "unread_count" )]
        public long? UnreadCount { get; set; }

        /// <summary>
        /// Number of unseen threads in the folder.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "unseen_count" )]
        public long? UnseenCount { get; set; }

        /// <summary>
        /// The highest action ID of a thread in a particular folder. This can be useful for checking whether there are any new threads in the folder.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "last_action_id" )]
        public long? LastActionId { get; set; }

        /// <summary>
        /// Last time the folder was accessed (Unix-type timestamp with millisecond resolution).
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "last_seen_time" )]
        public DateTime? LastSeenTime { get; set; }

        /// <summary>
        /// Total number of non-archived threads.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "total_threads" )]
        public long? TotalThreads { get; set; }

    }
}
