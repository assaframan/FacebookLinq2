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
    /// http://developers.facebook.com/docs/reference/fql/apprequest/
    /// </summary>
    [Table(Name = "apprequest")]
    public class Apprequest
    {
        /// <summary>
        /// The ID of an individual request
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "request_id" , IsPrimaryKey = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the app used to send the request. <strong>Note</strong> when indexing by app_id, you must also specify the recipient_uid.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "app_id" )]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the user who received the request. <strong>Note</strong> when indexing by recipient_uid, you must also specify the app_id.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "recipient_uid" )]
        public string RecipientUid { get; set; }

        /// <summary>
        /// The ID of the user who sent the request. This may be empty or not present for app-to-user requests made with the Graph API.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "sender_uid" )]
        public string SenderUid { get; set; }

        /// <summary>
        /// The message included with the request
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// Optional data passed with the request for tracking purposes
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "data" )]
        public string Data { get; set; }

        /// <summary>
        /// Unix timestamp that indicates when the request was sent
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

    }
}
