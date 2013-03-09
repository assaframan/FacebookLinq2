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
    /// https://developers.facebook.com/docs/reference/fql/mailbox_folder
    /// </summary>
    [Table(Name = "mailbox_folder")]
    public class MailboxFolder
    {
        /// <summary>
        /// The ID of the folder being queried. The ID can be one of: 0 (for Inbox), 1 (for Outbox), or 4 (for Updates).
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "folder_id" , IsPrimaryKey = true)]
        public FolderId FolderId { get; set; }

        /// <summary>
        /// A short description of the folder being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The number of total threads.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "total_count" )]
        public object TotalCount { get; set; }

        /// <summary>
        /// The number of unread threads in the folder being queried.
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "unread_count" )]
        public object UnreadCount { get; set; }

        /// <summary>
        /// The ID of the user whose folder you are querying.
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "viewer_id" )]
        public Uid ViewerId { get; set; }

    }
}
