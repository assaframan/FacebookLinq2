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
    /// https://developers.facebook.com/docs/reference/fql/event_member
    /// </summary>
    [Table(Name = "event_member")]
    public class EventMember
    {
        /// <summary>
        /// The ID of the event being queried.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "eid" , IsPrimaryKey = true)]
        public EventId Eid { get; set; }

        /// <summary>
        /// The user ID of the person who invited the user in the uid field.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "inviter" )]
        public Uid Inviter { get; set; }

        /// <summary>
        /// The type of the object in the inviter field. Allowed values are: 'page' or 'user'
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "inviter_type" )]
        public string InviterType { get; set; }

        /// <summary>
        /// The reply status of the user for the event being queried. There are four possible return values: attending, unsure, declined, and not_replied.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "rsvp_status" )]
        public string RsvpStatus { get; set; }

        /// <summary>
        /// An ISO-8601 string representing the starting date and (optionally) time of the event being queried. This is particularly useful as a WHERE filter to speed up your query when querying for one or more user's events. But it cannot be used when querying for users invited to a particular event. Note - before the 'Events Timezone' migration, this field was a timestamp. See 'Events Timezone Migration Note' above for more information.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "start_time" )]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The user ID of the user for the event being queried.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

    }
}
