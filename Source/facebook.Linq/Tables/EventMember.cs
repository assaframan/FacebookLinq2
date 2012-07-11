using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/event_member/
    /// </summary>
    [Table(Name = "event_member")]
    public class EventMember
    {
        /// <summary>
        /// The user ID of the user for the event being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public string Uid { get; set; }

        /// <summary>
        /// The ID of the event being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "eid" )]
        public string Eid { get; set; }

        /// <summary>
        /// The reply status of the user for the event being queried.  There are four possible return values: <code>attending</code>, <code>unsure</code>, <code>declined</code>, and <code>not_replied</code>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "rsvp_status" )]
        public string RsvpStatus { get; set; }

        /// <summary>
        /// The timestamp when the event began or will begin.  This is particularly useful as a WHERE filter to speed up your query when querying for one or more user's events.  But it cannot be used when querying for users invited to a particular event.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "start_time" )]
        public DateTime StartTime { get; set; }

    }
}
