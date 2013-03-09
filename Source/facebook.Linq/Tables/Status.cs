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
    /// https://developers.facebook.com/docs/reference/fql/status
    /// </summary>
    [Table(Name = "status")]
    public class Status
    {
        /// <summary>
        /// The content of the status message.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" , IsPrimaryKey = true)]
        public string Message { get; set; }

        /// <summary>
        /// Facebook ID of the place associated with the status, if any.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "place_id" )]
        public object PlaceId { get; set; }

        /// <summary>
        /// The application that published the status originally.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "source" )]
        public object Source { get; set; }

        /// <summary>
        /// The ID of the status message.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "status_id" )]
        public StatusId StatusId { get; set; }

        /// <summary>
        /// UNIX timestamp of the date and time the status message was posted.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "time" )]
        public DateTime? Time { get; set; }

        /// <summary>
        /// The user ID of the current user.
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

    }
}
