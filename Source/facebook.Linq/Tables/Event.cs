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
    /// https://developers.facebook.com/docs/reference/fql/event
    /// </summary>
    [Table(Name = "event")]
    public class Event
    {
        /// <summary>
        /// The number of invitees to the event
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "all_members_count" , IsPrimaryKey = true)]
        public object AllMembersCount { get; set; }

        /// <summary>
        /// The number of invitees who have accepted the event invite
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "attending_count" )]
        public object AttendingCount { get; set; }

        /// <summary>
        /// Whether the viewer can invite friends to the event
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_invite_friends" )]
        public bool? CanInviteFriends { get; set; }

        /// <summary>
        /// Creator of the event
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "creator" )]
        public object Creator { get; set; }

        /// <summary>
        /// The number of invitees who have declined the event invite
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "declined_count" )]
        public object DeclinedCount { get; set; }

        /// <summary>
        /// Description of the event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// ID of the event
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "eid" )]
        public EventId Eid { get; set; }

        /// <summary>
        /// End time of the event (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "end_time" )]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Whether the event has a profile picture
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "has_profile_pic" )]
        public bool? HasProfilePic { get; set; }

        /// <summary>
        /// Whether the guest list is hidden for the event
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "hide_guest_list" )]
        public bool? HideGuestList { get; set; }

        /// <summary>
        /// Host of the event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "host" )]
        public string Host { get; set; }

        /// <summary>
        /// Whether the event only has a date specified
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_date_only" )]
        public bool? IsDateOnly { get; set; }

        /// <summary>
        /// Location of the event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "location" )]
        public string Location { get; set; }

        /// <summary>
        /// Name of the event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The number of invitees who have not yet replied to the event invite
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "not_replied_count" )]
        public object NotRepliedCount { get; set; }

        /// <summary>
        /// Event picture
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// Large event picture
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// Small event picture
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// Square event picture
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// Privacy of the event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "privacy" )]
        public string Privacy { get; set; }

        /// <summary>
        /// Start time of the event (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "start_time" )]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The link users can visit to buy a ticket to the event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "ticket_uri" )]
        public string TicketUri { get; set; }

        /// <summary>
        /// Timezone of the event
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "timezone" )]
        public string Timezone { get; set; }

        /// <summary>
        /// The number of invitees who have responded maybe to the event invite
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "unsure_count" )]
        public object UnsureCount { get; set; }

        /// <summary>
        /// Last update time of the event (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "update_time" )]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Venue hosting the event
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "venue" )]
        public Venue Venue { get; set; }

        /// <summary>
        /// Version of the event
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "version" )]
        public long? Version { get; set; }

    }
}
