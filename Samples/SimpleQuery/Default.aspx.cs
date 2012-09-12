using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using facebook;
using Facebook;
using System.Net;
using System.IO;
using facebook.Tables;

namespace SimpleQuery
{
	public partial class _Default : System.Web.UI.Page
	{
		string m_clientId = "231464590266507";
		string m_clientSecret = "9dd6ce54b4405dd1325d271d2419bc34";
		string m_scope = "email,read_stream,read_insights,offline_access,user_checkins,manage_notifications,read_mailbox,friends_birthday,user_hometown,friends_hometown,friends_relationship_details ";

		// the getting the token code is from here: http://multitiered.wordpress.com/tag/c/

		private static string GetRedirectUri()
		{
			var url = HttpContext.Current.Request.Url;
			string redirectUri = HttpUtility.UrlEncode(url.GetLeftPart(UriPartial.Authority) + "/");
			return redirectUri;
		}

		private string GetAccessToken()
        {
            if (HttpRuntime.Cache["access_token"] == null)
            {
                Dictionary<string, string> args = GetOauthTokens(Request.Params["code"]);
                HttpRuntime.Cache.Insert("access_token", args["access_token"], null, DateTime.Now.AddMinutes(Convert.ToDouble(args["expires"])), TimeSpan.Zero);
            } 

            return HttpRuntime.Cache["access_token"].ToString();
        }


        private Dictionary<string, string> GetOauthTokens(string code)
        {
            Dictionary<string, string> tokens = new Dictionary<string, string>();

			string redirectUri = GetRedirectUri();

            string url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&client_secret={2}&code={3}&scope={4}",
							m_clientId, redirectUri, m_clientSecret, code, m_scope);

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

			using(HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string retVal = reader.ReadToEnd();

                foreach (string token in retVal.Split('&'))
                {
                    tokens.Add(token.Substring(0, token.IndexOf("=")),
                    token.Substring(token.IndexOf("=") + 1, token.Length - token.IndexOf("=") - 1));
                }
            }

            return tokens;

        }

		protected void Page_Load(object sender, EventArgs e)
		{
			
			if (Request.Params["code"] == null)
			{
				string redirectUri = GetRedirectUri();

				string dialog_url = string.Format("http://www.facebook.com/dialog/oauth?client_id={0}&redirect_uri={1}&scope={2}",
								m_clientId, redirectUri, m_scope);
				Response.Redirect(dialog_url);
			}
			else
			{
				FqlToLinqSample();
			}
		}

		private void FqlToLinqSample()
		{
			var fb = new FacebookClient(GetAccessToken());
			var db = new FacebookDataContext(fb);

			var useQuerySyntax = true;
			var useMethodSyntax = false;

			if (useQuerySyntax)
			{

				/*
				
				var albumQuery = from album in db.Album where album.Aid == new AlbumId("20531316728_324257") select album;
				var albumResult = albumQuery.ToArray();

				var applicationQuery = from application in db.Application where
										   application.AppId == new AppId("231464590266507") // servicestack-dev
										   || application.Namespace == "skype" // Skype
										   || application.Namespace == "inthemafia" // Mafia Wars
										   || application.Namespace == "m_calendar" // MyCalendar
									   select application;  
				
				var applicationResult = applicationQuery.ToArray();

				var apprequestQuery = from apprequest in db.Apprequest
									  where apprequest.RecipientUid == db.Me
										 && apprequest.AppId == new AppId("231464590266507")
									  select apprequest;
				var apprequestResult = apprequestQuery.ToArray();
				 
				var checkinQuery = from checkin in db.Checkin where checkin.AuthorUid == db.Me  select checkin;
				var checkinResult = checkinQuery.ToArray();

				var albumObjectIdQuery = from album in db.Album where album.Aid == new AlbumId("20531316728_324257") select album.ObjectId;
				var commentQuery = from comment in db.Comment where albumObjectIdQuery.Contains(comment.ObjectId) select comment;
				var commentResult = commentQuery.ToArray();
				 
				var connectionQuery = from connection in db.Connection where connection.SourceId == db.Me select connection;
				var connectionResult = connectionQuery.ToArray();

				var cookiesQuery = from cookies in db.Cookies where cookies.Uid == db.Me select cookies;
				var cookiesResult = cookiesQuery.ToArray();

				var developerQuery = from developer in db.Developer where developer.DeveloperId == db.Me select developer;
				var developerResult = developerQuery.ToArray();

				var eventQuery = from event_ in db.Event where event_.Eid == new EventId("209798352393506") select event_;
				var eventResult = eventQuery.ToArray();


				var commentsQuery = from comments in db.Comment where comments.ObjectId == new ObjectId("483854529708") select comments;
				var commentsResult = commentsQuery.ToArray();

				var threadQuery = from thread in db.Thread where thread.FolderId == FolderId.Inbox select thread.ThreadId;
				var messageQuery = from message in db.Message where threadQuery.Contains(message.ThreadId) select message;
				var messageResult = messageQuery.ToArray();


				DateTime yesterday = DateTime.Today.AddDays(-1);
				var threadQuery2 = from thread in db.Thread where thread.FolderId == FolderId.Inbox select thread.ThreadId;
				var messageQuery2 = from message in db.Message
									where threadQuery2.Contains(message.ThreadId)
										&& message.CreatedTime > yesterday
									select message;
				var messageResult2 = messageQuery2.ToArray();

				var notificationQuery = from notification in db.Notification where notification.RecipientId == db.Me select notification;
				var notificationResult = notificationQuery.ToArray();

				var groupQuery = from group_ in db.Group where group_.Gid == new GroupId("146797922030397") select group_;
				var groupResult = groupQuery.ToArray();

				var streamQuery = from stream in db.Stream where stream.SourceId == db.Me select stream;
				var streamResult = streamQuery.ToArray();

				//*/

				var friendIds = from friend in db.Friend where friend.Uid1 == db.Me select friend.Uid2;
				var friendDetails = (from user in db.User where friendIds.Contains(user.Uid) select new { Uid = user.Uid, Name = user.Name, Picture = user.PicSmall });
				listFriends.DataSource = friendDetails.ToArray();
					DataBind();
			}
			else if (useMethodSyntax)
			{
				var friendIds2 = db.Friend.Where(t => t.Uid1 == db.Me).Select(t => t.Uid2);
				var friendDetails2 = db.User.Where(t => friendIds2.Contains(t.Uid)).Select(t => new { Name = t.Name, Picture = t.PicSmall }).Take(5);
				listFriends.DataSource = friendDetails2.ToArray();
				DataBind();
			}
		}

	}
}
