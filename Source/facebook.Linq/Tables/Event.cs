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
    /// http://developers.facebook.com/docs/reference/fql/event/
    /// </summary>
    [Table(Name = "event")]
    public class Event
    {
        /// <summary>
        /// The ID of the event being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "eid" , IsPrimaryKey = true)]
        public long Eid { get; set; }

        /// <summary>
        /// The name of the event being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// The tagline or summary of the event being queried. <strong><em>Deprecated</em></strong> - This column <a href="/roadmap/#event-object-fields">will be removed</a> on July 5th, 2012.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "tagline" )]
        public string Tagline { get; set; }

        /// <summary>
        /// The network ID of the event being queried. <strong><em>Deprecated</em></strong> - This column <a href="/roadmap/#event-object-fields">will be removed</a> on July 5th, 2012.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "nid" )]
        public long Nid { get; set; }

        /// <summary>
        /// The URL to the small-sized profile picture for the event being queried. The image can have a maximum width of 50px and a maximum height of 150px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_small" )]
        public string PicSmall { get; set; }

        /// <summary>
        /// The URL to the largest-sized profile picture for the event being queried. The image can have a maximum width of 200px and a maximum height of 600px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_big" )]
        public string PicBig { get; set; }

        /// <summary>
        /// The URL to the square-sized profile picture for the event being queried. The image is returned with a width and height of 50px.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic_square" )]
        public string PicSquare { get; set; }

        /// <summary>
        /// The URL to the medium-sized profile picture for the event being queried. The image can have a maximum width of 100px and a maximum height of 300px. This URL may be blank.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "pic" )]
        public string Pic { get; set; }

        /// <summary>
        /// The name of the host of the event being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "host" )]
        public string Host { get; set; }

        /// <summary>
        /// The description of the event being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The category of the event being queried. <strong><em>Deprecated</em></strong> - This column <a href="/roadmap/#event-object-fields">will be removed</a> on July 5th, 2012.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "event_type" )]
        public string EventType { get; set; }

        /// <summary>
        /// The event type for the event being queried. <strong><em>Deprecated</em></strong> - This column <a href="/roadmap/#event-object-fields">will be removed</a> on July 5th, 2012.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "event_subtype" )]
        public string EventSubtype { get; set; }

        /// <summary>
        /// The starting date and time of the event being queried.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "start_time" )]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The ending date and time of the event being queried.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "end_time" )]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The user ID of the creator of the event being queried.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "creator" )]
        public long Creator { get; set; }

        /// <summary>
        /// The time that the event being queried was last updated.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "update_time" )]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// The location of the event being queried.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "location" )]
        public string Location { get; set; }

        /// <summary>
        /// The venue where the event being queried is being held. Contains one or more of the following fields: <code>street</code>, <code>city</code>, <code>state</code>, <code>zip</code>, <code>country</code>, <code>latitude</code>, and <code>longitude</code>.
        /// 
        /// original type is: array
        /// </summary>
        [Column(Name = "venue" )]
        public JsonObject Venue { get; set; }

        /// <summary>
        /// The privacy setting of the event being queried, indicating whether the event is <code>OPEN</code>, <code>CLOSED</code>, or <code>SECRET</code>.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "privacy" )]
        public string Privacy { get; set; }

        /// <summary>
        /// Indicates whether the guest list on the event's page is hidden..
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "hide_guest_list" )]
        public bool HideGuestList { get; set; }

        /// <summary>
        /// Indicates whether or not the viewer can invite friends to the event.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "can_invite_friends" )]
        public bool CanInviteFriends { get; set; }

        /// <summary>
        /// The number of invitees to the event.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "all_members_count" )]
        public long AllMembersCount { get; set; }

        /// <summary>
        /// The number of invitees who have accepted the event invite.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "attending_count" )]
        public long AttendingCount { get; set; }

        /// <summary>
        /// The number of invitees who have responded maybe to the event invite.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "unsure_count" )]
        public long UnsureCount { get; set; }

        /// <summary>
        /// The number of invitees who have declined the event invite.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "declined_count" )]
        public long DeclinedCount { get; set; }

        /// <summary>
        /// The number of invitees who have not yet replied to the event invite.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "not_replied_count" )]
        public long NotRepliedCount { get; set; }

    }
}
