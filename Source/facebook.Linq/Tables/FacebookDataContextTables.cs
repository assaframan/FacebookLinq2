using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facebook.Linq;
using facebook.Tables;

namespace Facebook
{
    public partial class FacebookDataContext
    {
        public FqlTable<Album> Album
        {
            get
            {
                return GetTable<Album>();
            }
        }

        public FqlTable<Application> Application
        {
            get
            {
                return GetTable<Application>();
            }
        }

        public FqlTable<Apprequest> Apprequest
        {
            get
            {
                return GetTable<Apprequest>();
            }
        }

        public FqlTable<Checkin> Checkin
        {
            get
            {
                return GetTable<Checkin>();
            }
        }

        public FqlTable<Comment> Comment
        {
            get
            {
                return GetTable<Comment>();
            }
        }

        public FqlTable<CommentsInfo> CommentsInfo
        {
            get
            {
                return GetTable<CommentsInfo>();
            }
        }

        public FqlTable<Connection> Connection
        {
            get
            {
                return GetTable<Connection>();
            }
        }

        public FqlTable<Cookies> Cookies
        {
            get
            {
                return GetTable<Cookies>();
            }
        }

        public FqlTable<Developer> Developer
        {
            get
            {
                return GetTable<Developer>();
            }
        }

        public FqlTable<Domain> Domain
        {
            get
            {
                return GetTable<Domain>();
            }
        }

        public FqlTable<DomainAdmin> DomainAdmin
        {
            get
            {
                return GetTable<DomainAdmin>();
            }
        }

        public FqlTable<Event> Event
        {
            get
            {
                return GetTable<Event>();
            }
        }

        public FqlTable<EventMember> EventMember
        {
            get
            {
                return GetTable<EventMember>();
            }
        }

        public FqlTable<Family> Family
        {
            get
            {
                return GetTable<Family>();
            }
        }

        public FqlTable<Friend> Friend
        {
            get
            {
                return GetTable<Friend>();
            }
        }

        public FqlTable<FriendRequest> FriendRequest
        {
            get
            {
                return GetTable<FriendRequest>();
            }
        }

        public FqlTable<Friendlist> Friendlist
        {
            get
            {
                return GetTable<Friendlist>();
            }
        }

        public FqlTable<FriendlistMember> FriendlistMember
        {
            get
            {
                return GetTable<FriendlistMember>();
            }
        }

        public FqlTable<Group> Group
        {
            get
            {
                return GetTable<Group>();
            }
        }

        public FqlTable<GroupMember> GroupMember
        {
            get
            {
                return GetTable<GroupMember>();
            }
        }

        public FqlTable<Insights> Insights
        {
            get
            {
                return GetTable<Insights>();
            }
        }

        public FqlTable<Like> Like
        {
            get
            {
                return GetTable<Like>();
            }
        }

        public FqlTable<Link> Link
        {
            get
            {
                return GetTable<Link>();
            }
        }

        public FqlTable<LinkStat> LinkStat
        {
            get
            {
                return GetTable<LinkStat>();
            }
        }

        public FqlTable<LocationPost> LocationPost
        {
            get
            {
                return GetTable<LocationPost>();
            }
        }

        public FqlTable<MailboxFolder> MailboxFolder
        {
            get
            {
                return GetTable<MailboxFolder>();
            }
        }

        public FqlTable<Message> Message
        {
            get
            {
                return GetTable<Message>();
            }
        }

        public FqlTable<Note> Note
        {
            get
            {
                return GetTable<Note>();
            }
        }

        public FqlTable<Notification> Notification
        {
            get
            {
                return GetTable<Notification>();
            }
        }

        public FqlTable<ObjectUrl> ObjectUrl
        {
            get
            {
                return GetTable<ObjectUrl>();
            }
        }

        public FqlTable<Offer> Offer
        {
            get
            {
                return GetTable<Offer>();
            }
        }

        public FqlTable<Page> Page
        {
            get
            {
                return GetTable<Page>();
            }
        }

        public FqlTable<PageAdmin> PageAdmin
        {
            get
            {
                return GetTable<PageAdmin>();
            }
        }

        public FqlTable<PageBlockedUser> PageBlockedUser
        {
            get
            {
                return GetTable<PageBlockedUser>();
            }
        }

        public FqlTable<PageFan> PageFan
        {
            get
            {
                return GetTable<PageFan>();
            }
        }

        public FqlTable<PageMilestone> PageMilestone
        {
            get
            {
                return GetTable<PageMilestone>();
            }
        }

        public FqlTable<Permissions> Permissions
        {
            get
            {
                return GetTable<Permissions>();
            }
        }

        public FqlTable<PermissionsInfo> PermissionsInfo
        {
            get
            {
                return GetTable<PermissionsInfo>();
            }
        }

        public FqlTable<Photo> Photo
        {
            get
            {
                return GetTable<Photo>();
            }
        }

        public FqlTable<PhotoSrc> PhotoSrc
        {
            get
            {
                return GetTable<PhotoSrc>();
            }
        }

        public FqlTable<PhotoTag> PhotoTag
        {
            get
            {
                return GetTable<PhotoTag>();
            }
        }

        public FqlTable<Place> Place
        {
            get
            {
                return GetTable<Place>();
            }
        }

        public FqlTable<Privacy> Privacy
        {
            get
            {
                return GetTable<Privacy>();
            }
        }

        public FqlTable<PrivacySetting> PrivacySetting
        {
            get
            {
                return GetTable<PrivacySetting>();
            }
        }

        public FqlTable<Profile> Profile
        {
            get
            {
                return GetTable<Profile>();
            }
        }

        public FqlTable<ProfilePic> ProfilePic
        {
            get
            {
                return GetTable<ProfilePic>();
            }
        }

        public FqlTable<ProfileView> ProfileView
        {
            get
            {
                return GetTable<ProfileView>();
            }
        }

        public FqlTable<Question> Question
        {
            get
            {
                return GetTable<Question>();
            }
        }

        public FqlTable<QuestionOption> QuestionOption
        {
            get
            {
                return GetTable<QuestionOption>();
            }
        }

        public FqlTable<QuestionOptionVotes> QuestionOptionVotes
        {
            get
            {
                return GetTable<QuestionOptionVotes>();
            }
        }

        public FqlTable<Review> Review
        {
            get
            {
                return GetTable<Review>();
            }
        }

        public FqlTable<StandardFriendInfo> StandardFriendInfo
        {
            get
            {
                return GetTable<StandardFriendInfo>();
            }
        }

        public FqlTable<StandardUserInfo> StandardUserInfo
        {
            get
            {
                return GetTable<StandardUserInfo>();
            }
        }

        public FqlTable<Status> Status
        {
            get
            {
                return GetTable<Status>();
            }
        }

        public FqlTable<Stream> Stream
        {
            get
            {
                return GetTable<Stream>();
            }
        }

        public FqlTable<StreamFilter> StreamFilter
        {
            get
            {
                return GetTable<StreamFilter>();
            }
        }

        public FqlTable<StreamTag> StreamTag
        {
            get
            {
                return GetTable<StreamTag>();
            }
        }

        public FqlTable<Subscription> Subscription
        {
            get
            {
                return GetTable<Subscription>();
            }
        }

        public FqlTable<Thread> Thread
        {
            get
            {
                return GetTable<Thread>();
            }
        }

        public FqlTable<Translation> Translation
        {
            get
            {
                return GetTable<Translation>();
            }
        }

        public FqlTable<UnifiedMessage> UnifiedMessage
        {
            get
            {
                return GetTable<UnifiedMessage>();
            }
        }

        public FqlTable<UnifiedThread> UnifiedThread
        {
            get
            {
                return GetTable<UnifiedThread>();
            }
        }

        public FqlTable<UnifiedThreadAction> UnifiedThreadAction
        {
            get
            {
                return GetTable<UnifiedThreadAction>();
            }
        }

        public FqlTable<UnifiedThreadCount> UnifiedThreadCount
        {
            get
            {
                return GetTable<UnifiedThreadCount>();
            }
        }

        public FqlTable<UrlLike> UrlLike
        {
            get
            {
                return GetTable<UrlLike>();
            }
        }

        public FqlTable<User> User
        {
            get
            {
                return GetTable<User>();
            }
        }

        public FqlTable<Video> Video
        {
            get
            {
                return GetTable<Video>();
            }
        }

        public FqlTable<VideoTag> VideoTag
        {
            get
            {
                return GetTable<VideoTag>();
            }
        }

    }
}
