using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/unified_thread_action/
    /// </summary>
    [Table(Name = "unified_thread_action")]
    public class UnifiedThreadAction
    {
        /// <summary>
        /// A unique version identifier that is increasing in the same order as the actions that have been performed.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "action_id" , IsPrimaryKey = true)]
        public string ActionId { get; set; }

        /// <summary>
        /// The user who performed the action. This field is an object with properties <code>name</code> (string), <code>email</code> (string) and <code>user_id</code> (string).
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "actor" )]
        public string Actor { get; set; }

        /// <summary>
        /// Unique identifier of the thread.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "thread_id" )]
        public string ThreadId { get; set; }

        /// <summary>
        /// Time at which the action was performed (Unix-type timestamp with millisecond resolution).
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "timestamp" )]
        public string Timestamp { get; set; }

        /// <summary>
        /// Flag to indicate whether the action is a subscribe (1) or unsubscribe (2).
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "type" )]
        public long Type { get; set; }

        /// <summary>
        /// List of users on whom the action was performed. Each element of the list is an object with properties <code>name</code> (string), <code>email</code> (string) and <code>user_id</code> (string).
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "users" )]
        public string Users { get; set; }

    }
}
