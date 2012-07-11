FacebookLinq2
=============

### Project summary
Facebook Linq to Fql makes it easier for facebook developers to work with facebook data.
You’ll no longer have to use untyped Fql queries.
Instead, you can work with compiled Linq queries using the Facebook object model.

FacebookLinq was a dead project that didn't compile and wasn't updated since 2009, I decided that the idea is good andcreated my modified version that is based on the original FacebookLinq.
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
* Preformance can always be improved.

### Credits and licences:
The code of the facebook.Linq project is based on [FacebookLinq] - and it has the same code licence as in the project link on this line.
The code of the SimpleQuery project is based on [FacebookLinq] - and it has the same code licence as in the project link on this line.
The code for the Facebook project is based on [facebook-csharp-sdk] - and it has the same code licence as in the project link on this line.
The code for the CreateTableClassesFromFacebookPages project is based on [facebook-csharp-sdk] - and it has the same code licence as in the project link on this line.

[FacebookLinq]: http://facebooklinq.codeplex.com/
[facebook-csharp-sdk]: https://github.com/facebook-csharp-sdk/facebook-csharp-sdk/
