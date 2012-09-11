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
    /// http://developers.facebook.com/docs/reference/fql/notification/
    /// </summary>
    [Table(Name = "notification")]
    public class Notification
    {
        /// <summary>
        /// The ID of the notification. This ID is not globally unique, so the recipient_id must be specified in addition to it.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "notification_id" , IsPrimaryKey = true)]
        public NotificationId NotificationId { get; set; }

        /// <summary>
        /// The user ID of the sender of the notification.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "sender_id" )]
        public Uid SenderId { get; set; }

        /// <summary>
        /// The user ID of the recipient of the notification. It is always the current session user.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "recipient_id" )]
        public Uid RecipientId { get; set; }

        /// <summary>
        /// The time the notification was originally sent. Notifications older than 7 days are deleted and will not be returned via this table.
        /// 
        /// original type is: ISO-8601 datetime
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The time the notification was originally sent, or the time the notification was updated, whichever is later.
        /// 
        /// original type is: ISO-8601 datetime
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The main body of the notification in HTML.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title_html" )]
        public string TitleHtml { get; set; }

        /// <summary>
        /// The plaintext version of title_html, with all HTML tags stripped out.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title_text" )]
        public string TitleText { get; set; }

        /// <summary>
        /// Any additional content the notification includes, in HTML.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "body_html" )]
        public string BodyHtml { get; set; }

        /// <summary>
        /// The plaintext version of body_html, with all HTML tags stripped out.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "body_text" )]
        public string BodyText { get; set; }

        /// <summary>
        /// The URL associated with the notification. This is usually a location where the user can interact with the subject of the notification.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "href" )]
        public string Href { get; set; }

        /// <summary>
        /// The ID of the application associated with the notification. This may be a third-party application or a Facebook application (for example, Wall).
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "app_id" )]
        public AppId AppId { get; set; }

        /// <summary>
        /// Indicates whether the notification has been marked as read. Use notifications.markRead to mark a notification as read.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_unread" )]
        public bool? IsUnread { get; set; }

        /// <summary>
        /// Indicates whether the user hid the associated application's notifications.
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_hidden" )]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// The object id of the notification.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "object_id" )]
        public string ObjectId { get; set; }

        /// <summary>
        /// The object type (e.g. stream, photo, event etc.) of the notification.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "object_type" )]
        public string ObjectType { get; set; }

        /// <summary>
        /// The URL associated with the notification's icon.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "icon_url" )]
        public string IconUrl { get; set; }

    }
}
