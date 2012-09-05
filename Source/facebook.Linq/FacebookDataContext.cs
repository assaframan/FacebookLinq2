using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facebook.Linq;
using facebook.Tables;

namespace Facebook
{
	
	/// <summary>
	/// The Facebook Database. Queries on tables on an instance will be done against the facebook servers.
	/// </summary>
	public partial class FacebookDataContext : FqlDataContext
	{
		/// <summary>
		/// Creates a FacebookDataContext using the specified api
		/// </summary>
		/// <param name="api"></param>
		public FacebookDataContext(FacebookClient api)
			: base(api)
		{
		}

		public Uid Me
		{ 
			get
			{
				return new Uid(-1); // some fake value
			}			
		}
	}
}
