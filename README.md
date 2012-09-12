FacebookLinq2
=============

### Project summary
Facebook Linq to Fql makes it easier for facebook developers to work with facebook data.
You�ll no longer have to use untyped Fql queries.
Instead, you can work with compiled Linq queries using the Facebook object model.

FacebookLinq was a dead project that didn't compile and wasn't updated since 2009, I decided that the idea is good and created my modified version that is based on the original FacebookLinq.
My goals where:

* Get the code to run with the latest facebook-csharp-sdk.
* Create code that generates classes for the FQL tables based on the FQL documentation on Facebook's site.

### Use example
This C# code:

    var friendIds = from friend in db.Friend where friend.Uid1 == db.Me select friend.Uid2;
    var friendDetails = (from user in db.User where  
    friendIds.Contains(user.Uid)      select new { Name = user.Name, Picture = user.PicSmall }).Take(5);
    listFriends.DataSource = friendDetails.ToArray();

Will execute the following FQL:

    select name , pic_small from user where uid in ( select uid2 from friend where uid1 = me()  ) limit  5

### Here is the list of changes I made to the original "facebook.Linq" code:
* I made it work with the latest facebook-csharp-sdk project.
* I created a class generator that reads the Facebook FQL documentation pages and generates C# classes from the pages, this saved me the time creating them by hand, and also a way to quickly update them with future changes. The project is named CreateTableClassesFromFacebookPages, it logins to Facebook at start - as some of the FQL documentation pages require the user to be logged in to view them.
* I fixed the SimpleQuery webpage sample project that demonstrate the facebook.Linq to work with the latest facebook-csharp-sdk and my new naming changes.

### Todo:
* CreateTableClassesFromFacebookPages is a quick hack - it may be a good idea to sort the code out and add support for all the special datatypes that are converted to string for now.
* Performance can always be improved.

### Credits and licenses:
The code of the facebook.Linq project is based on [FacebookLinq] - and it has the same code license as in the project link on this line.
The code of the SimpleQuery project is based on [FacebookLinq] - and it has the same code license as in the project link on this line.
The code for the Facebook project is based on [facebook-csharp-sdk] - and it has the same code license as in the project link on this line.
The code for the CreateTableClassesFromFacebookPages project is based on [facebook-csharp-sdk] - and it has the same code license as in the project link on this line.

[FacebookLinq]: http://facebooklinq.codeplex.com/
[facebook-csharp-sdk]: https://github.com/facebook-csharp-sdk/facebook-csharp-sdk/


### Here are some more use examples:
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
