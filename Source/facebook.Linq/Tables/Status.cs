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
    /// http://developers.facebook.com/docs/reference/fql/status/
    /// </summary>
    [Table(Name = "status")]
    public class Status
    {
        /// <summary>
        /// The user ID of the current user.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public Uid Uid { get; set; }

        /// <summary>
        /// The ID of the status message.
        /// 
        /// original type is: string
        /// Indexable
        /// </summary>
        [Column(Name = "status_id" )]
        public StatusId StatusId { get; set; }

        /// <summary>
        /// UNIX timestamp of the date and time the status message was posted.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "time" )]
        public DateTime? Time { get; set; }

        /// <summary>
        /// The application that published the status originally.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "source" )]
        public long? Source { get; set; }

        /// <summary>
        /// The content of the status message.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// Facebook ID of the place associated with the status, if any.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "place_id" )]
        public long? PlaceId { get; set; }

    }
}
