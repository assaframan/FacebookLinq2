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
    /// https://developers.facebook.com/docs/reference/fql/unified_thread_action
    /// </summary>
    [Table(Name = "unified_thread_action")]
    public class UnifiedThreadAction
    {
        /// <summary>
        /// A unique version ID that is increasing in the same order as the actions that have been performed
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "action_id" , IsPrimaryKey = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// The user who performed the action
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "actor" )]
        public object Actor { get; set; }

        /// <summary>
        /// Body of the thread action
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "body" )]
        public string Body { get; set; }

        /// <summary>
        /// Internal ID for the message
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "internal_message_id" )]
        public string InternalMessageId { get; set; }

        /// <summary>
        /// ID of the thread
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" )]
        public ThreadId ThreadId { get; set; }

        /// <summary>
        /// Time at which the action was performed (UNIX timestamp)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "timestamp" )]
        public string Timestamp { get; set; }

        /// <summary>
        /// Flag to indicate whether the action is a subscribe (1) or unsubscribe (2)
        /// 
        /// original type is: int32
        /// </summary>
        [Column(Name = "type" )]
        public object Type { get; set; }

        /// <summary>
        /// List of users on whom the action was performed
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "users" )]
        public object Users { get; set; }

    }
}
