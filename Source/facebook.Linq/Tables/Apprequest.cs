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
    /// https://developers.facebook.com/docs/reference/fql/apprequest
    /// </summary>
    [Table(Name = "apprequest")]
    public class Apprequest
    {
        /// <summary>
        /// The ID of the app used to send the request. Note when indexing by app_id, you must also specify the recipient_uid.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "app_id" , IsPrimaryKey = true)]
        public AppId AppId { get; set; }

        /// <summary>
        /// UNIX timestamp that indicates when the request was sent
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Optional data passed with the request for tracking purposes
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "data" )]
        public string Data { get; set; }

        /// <summary>
        /// The message included with the request
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the user who received the request. Note when indexing by recipient_uid, you must also specify the app_id.
        /// 
        /// original type is: (number) or (StartNowHID)
        /// </summary>
        [Column(Name = "recipient_uid" )]
        public Uid RecipientUid { get; set; }

        /// <summary>
        /// The ID of an individual request
        /// 
        /// original type is: (number) or (string)
        /// </summary>
        [Column(Name = "request_id" )]
        public RequestId RequestId { get; set; }

        /// <summary>
        /// The ID of the user who sent the request. This may be empty or not present for app-to-user requests made with the Graph API.
        /// 
        /// original type is: (number) or (StartNowHID)
        /// </summary>
        [Column(Name = "sender_uid" )]
        public Uid SenderUid { get; set; }

    }
}
