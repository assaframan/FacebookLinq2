using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CreateTableClassesFromFacebookPages
{
	class CreateTableClassesFromFacebookPages
	{

		/// <summary>
		/// Function to download HTML web page
		/// </summary>
		/// <param name="_URL">URL address to download web page</param>
		/// <returns>HTML contents as a string</returns>
		static public string DownloadHTMLPage(string _URL, string _accessToken)
		{
			var fb = new FacebookClient(_accessToken);
			return fb.GetPage(_URL);

		}


		static public void doit(string _accessToken)
		{
			string fqlRootPage = DownloadHTMLPage(@"http://developers.facebook.com/docs/reference/fql/", _accessToken);
			string[] fqlRootPageLines = Regex.Split(fqlRootPage, "\n");
			bool foundTables = false;


			System.IO.StreamWriter mainFile = new System.IO.StreamWriter("..\\..\\..\\..\\Source\\facebook.Linq\\Tables\\FacebookDataContextTables.cs");
			mainFile.WriteLine("using System;");
			mainFile.WriteLine("using System.Collections.Generic;");
			mainFile.WriteLine("using System.Linq;");
			mainFile.WriteLine("using System.Web;");
			mainFile.WriteLine("using Facebook.Linq;");
			mainFile.WriteLine("using facebook.Tables;");
			mainFile.WriteLine("");
			mainFile.WriteLine("namespace Facebook");
			mainFile.WriteLine("{");
			mainFile.WriteLine("    public partial class FacebookDataContext");
			mainFile.WriteLine("    {");


			foreach (string line in fqlRootPageLines)
			{
				if (foundTables)
				{
					if (line.StartsWith(@"</div></div><div class="))
					{
						HendleTableLine(line, _accessToken, mainFile);
					}
					else
					{
						break;
					}
				}
				else
				{
					if (line.StartsWith(@"<ul></ul><hr /><h2 id=""tables"">Tables</h2>"))
					{
						HendleTableLine(line, _accessToken, mainFile);
						foundTables = true;
					}
				}
			}
			mainFile.WriteLine("    }");
			mainFile.WriteLine("}");
			mainFile.Close();


		}
		static string ToCapitalString(string s)
		{
			string result = s;
			result = result.Replace("_", " ");
			result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result);
			result = result.Replace(" ", "");
			return result;
		}
		private static void HendleTableLine(string line, string _accessToken, System.IO.StreamWriter mainFile)
		{
			string theLine = line.Substring(line.IndexOf(@"<div class=""title"">"));
			string[] parts = Regex.Split(theLine, ">");
			string name = parts[2].Substring(0, parts[2].Length - 3);
			string capitalName = ToCapitalString(name);
			string url = parts[1].Substring(9, parts[1].Length - 1 - 9);


			mainFile.WriteLine("        public FqlTable<" + capitalName  + "> " + capitalName);
			mainFile.WriteLine("        {");
			mainFile.WriteLine("            get");
			mainFile.WriteLine("            {");
			mainFile.WriteLine("                return GetTable<" + capitalName + ">();");
			mainFile.WriteLine("            }");
			mainFile.WriteLine("        }");
			mainFile.WriteLine("");

			string tablePage = DownloadHTMLPage(url, _accessToken);
			string[] tablePageLines = Regex.Split(tablePage, "\n");

			System.IO.StreamWriter file = new System.IO.StreamWriter("..\\..\\..\\..\\Source\\facebook.Linq\\Tables\\" + capitalName + ".cs");

			file.WriteLine("using System;");
			file.WriteLine("using System.Collections.Generic;");
			file.WriteLine("using System.Linq;");
			file.WriteLine("using System.Text;");
			file.WriteLine("using Facebook.Linq;");
			file.WriteLine("using System.Data.Linq.Mapping;");
			file.WriteLine("using Facebook;");
			
			file.WriteLine("");
			file.WriteLine("namespace facebook.Tables");
			file.WriteLine("{");
			file.WriteLine("    /// <summary>");
			file.WriteLine("    /// " + url);
			file.WriteLine("    /// </summary>");
			file.WriteLine("    [Table(Name = \"" + name + "\")]");
			file.WriteLine("    public class " + capitalName);
			file.WriteLine("    {");	
			
			bool first = true;
			foreach (string fieldLine in tablePageLines)
			{
				if (fieldLine.IndexOf(@"<td class=""indexable"">") > 0)
				{
					HendleTableField(first, fieldLine, file, tablePage, name);
					first = false;
				}
			}

			file.WriteLine("    }");
			file.WriteLine("}");
			file.Close();
		}

		static string lastName = "";
		private static void HendleTableField(bool isFirst, string fieldLine, System.IO.StreamWriter file, string pageText, string tableName)
		{
			string theLine = fieldLine.Substring(fieldLine.IndexOf(@"<td class=""indexable"">"));
			string[] parts = Regex.Split(theLine, ">");
			string name = parts[3].Substring(0, parts[3].Length - 4);
			if (lastName == name)
			{
				return;
			}
			lastName = name;
			string capitalName = ToCapitalString(name);
			if (tableName == name)
			{
				capitalName = capitalName + "_";
			}
			string theType = parts[5].Substring(0, parts[5].Length - 4);

			string description = pageText;
			description = description.Substring(description.IndexOf("<td class=\"name\">" + name + "</td><td class=\"type\">") + 1);
			int posOfEnd =  description.IndexOf("<td class=\"name\">");
			if (posOfEnd == -1)
			{
				posOfEnd = description.IndexOf("</table>");
			}
			description = description.Substring(0, posOfEnd);

			int posOfP = description.IndexOf("<p>");


			description = description.Substring(posOfP + 3);

			int posOfEndP = description.LastIndexOf("</p>");

			description = description.Substring(0, posOfEndP);

			description = description.Replace("<code>", "");
			description = description.Replace("</code>", "");

			string IsPrimaryKeyString = "";
			if (isFirst)
			{
				IsPrimaryKeyString = ", IsPrimaryKey = true";
			}

			string cSharpTypeToUse = theType;

			name = name.Trim();

			if ( 
				   (name == "update_ip_whitelist")
				|| (name == "server_ip_whitelist")
			   )
				
			{
				return;
			}

			if (theType != "array" &&
					(
						description.Contains("user ID") 
						|| description.Contains("User ID")
						|| description.Contains("ID of the user")
						|| name == "viewer_id"
					)
				&& name != "third_party_id"
				)
			{
				cSharpTypeToUse = "Uid";
			}
			else if (IsIdField("App", false, description, name, ref cSharpTypeToUse)) {}
			else if (IsIdField("Request", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Status", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Domain", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Checkin", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Page", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Post", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Event", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("FriendList", name == "flid", description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Link", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Group", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Thread", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Notification", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Offer", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Milestone", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Photo", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Review", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Message", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Video", false, description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("Object", name.EndsWith("_object_id"), description, name, ref cSharpTypeToUse)) { }
			else if (IsIdField("ThirdParty", name == "third_party_id", description, name, ref cSharpTypeToUse)) { }
			else if (name.EndsWith("_xid") || name == "xid")
			{
				cSharpTypeToUse = "Xid";
			}
			else if (name == "folder_id")
			{
				cSharpTypeToUse = "FolderId";
			}
			else if (name == "type" && tableName == "stream")
			{
				cSharpTypeToUse = "StreamType";
			}
			else if (name == "id" && tableName == "comment")
			{
				cSharpTypeToUse = "CommentId";
			}
			else if (name == "id" && tableName == "object_url")
			{
				cSharpTypeToUse = "ObjectUrlId";
			}
			else if (name == "id" && tableName == "profile")
			{
				cSharpTypeToUse = "ProfileId";
			}
			else if (name == "id" && tableName == "question")
			{
				cSharpTypeToUse = "QuestionId";
			}
			else if (name == "id" && tableName == "question_option")
			{
				cSharpTypeToUse = "QuestionOptionId";
			}
			else if (name == "id" && tableName == "note")
			{
				cSharpTypeToUse = "NoteId";
			}
			else if (name == "source_id" && tableName == "connection")
			{
				cSharpTypeToUse = "Uid";
			}
			else if (name == "source_id" && tableName == "stream")
			{
				cSharpTypeToUse = "UnionId";
			}
			else if (name == "actor_id" && tableName == "stream")
			{
				cSharpTypeToUse = "UnionId";
			}
			else if (name == "actor_id" && tableName == "stream_tag")
			{
				cSharpTypeToUse = "Uid";
			}
			else if (name == "target_id" && tableName == "connection")
			{
				cSharpTypeToUse = "ConnectionTargetId";
			}
			else if (name == "owner_id" && tableName == "domain_admin")
			{
				cSharpTypeToUse = "DomainOwnerId";
			}
			else if (name == "owner_id" && tableName == "offer")
			{
				cSharpTypeToUse = "PageId";
			}
			else if (name == "owner_id" && tableName == "page_milestone")
			{
				cSharpTypeToUse = "PageId";
			}
			else if (name == "fromid")
			{
				cSharpTypeToUse = "Uid";
			}
			else if (name == "target_id" && tableName == "stream")
			{
				cSharpTypeToUse = "StreamTargetId";
			}
			else if (name == "target_id")
			{
				cSharpTypeToUse = "UnionId";
			}
			else if (name == "subject" && tableName == "photo_tag")
			{
				cSharpTypeToUse = "Subject";
			}
			else if (name == "version")
			{
				cSharpTypeToUse = "long?";
			}
			else if (name == "post_fbid" && tableName == "comment")
			{
				cSharpTypeToUse = "ObjectId";
			}
			else if (name == "aid")
			{
				cSharpTypeToUse = "AlbumId";
			}
			else if (name == "id" && tableName == "privacy")
			{
				cSharpTypeToUse = "ObjectId";
			}
			else if (name == "coords")
			{
				cSharpTypeToUse = "Coords";
			}
			else if (name == "venue")
			{
				cSharpTypeToUse = "Venue";
			}
			else if (name == "like_info")
			{
				cSharpTypeToUse = "LikeInfo";
			}
			else if (name == "comment_info")
			{
				cSharpTypeToUse = "CommentInfo";
			}
			else if (name.EndsWith("_time"))
			{
				cSharpTypeToUse = "DateTime?";
			}
			else if (name == "time")
			{
				cSharpTypeToUse = "DateTime?";
			}
			else if (theType == "int")
			{
				if (name == "post_id")
				{
					cSharpTypeToUse = "string";
				}
				else if (name == "uid" || name == "uid1" || name == "uid2" || name.EndsWith("_uid") || name == "user_id")
				{
					cSharpTypeToUse = "Uid";
				}
				else
				{
					cSharpTypeToUse = "long?";
				}
			}
			else if (theType == "time")
			{
				cSharpTypeToUse = "DateTime?";
			}
			else if (theType == "ISO-8601 datetime")
			{
				cSharpTypeToUse = "DateTime?";
			}
			else if (theType == "object")
			{
				cSharpTypeToUse = "JsonObject";
			}
			else if (name == "tagged_uids")
			{
				cSharpTypeToUse = "UidsList";
			}
			else if (name == "recipients")
			{
				cSharpTypeToUse = "UidsList";
			}					
			else if (name == "image_urls")
			{
				cSharpTypeToUse = "Urls";
			}					
			else if (name == "devices")
			{
				cSharpTypeToUse = "Devices";
			}
			else if ((name == "description_tags") || (name == "message_tags") || (name == "text_tags"))
			{
				cSharpTypeToUse = "Tags";
			}
			else if (name == "hometown_location")
			{
				cSharpTypeToUse = "HometownLocationType";
			}
			else if (name == "meeting_sex")
			{
				cSharpTypeToUse = "Genders";
			}
			else if (name == "developers")
			{
				cSharpTypeToUse = "Developers";
			}
			else if (name == "app_domains")
			{
				cSharpTypeToUse = "AppDomains";
			}
			else if (   name == "auth_referral_user_perms" 
					 || name == "auth_referral_friend_perms"
					 || name == "auth_referral_extended_perms"				
				    )
			{
				cSharpTypeToUse = "Auths";
			}
			else if (theType == "comments")
			{
				cSharpTypeToUse = "object";
			}
			else if (theType == "mixed")
			{
				cSharpTypeToUse = "object";
			}
			else if (theType == "bool")
			{
				cSharpTypeToUse = "bool?";
			}
			else if (theType == "boolean")
			{
				cSharpTypeToUse = "bool?";
			}	
			else if (theType == "float")
			{
				cSharpTypeToUse = "float?";
			}	
			else if (theType == "string")
			{
				if (name == "parent_message_id")
				{
					cSharpTypeToUse = "long?";
				}
				else
				{
					cSharpTypeToUse = "string";
				}
			}
			else				
			{
				cSharpTypeToUse = "object";
			}

			file.WriteLine("        /// <summary>");
			string[] descriptionLines = Regex.Split(description, "\n");
			foreach (string descriptionLine in descriptionLines)
			{
				file.WriteLine("        /// " + descriptionLine);
			}
			file.WriteLine("        /// ");
			file.WriteLine("        /// original type is: " + theType);
			if (parts[1] == "*</td")
			{
				file.WriteLine("        /// Indexable");
			} file.WriteLine("        /// </summary>");


			file.WriteLine("        [Column(Name = \"" + name + "\" " + IsPrimaryKeyString  + ")]");
			file.WriteLine("        public " + cSharpTypeToUse + " " + capitalName + " { get; set; }");
			file.WriteLine("");

		}

		private static bool IsIdField(string idName, bool thisIsTheField, string description, string name, ref string cSharpTypeToUse)
		{
			if (description.Contains("ID of the " + idName.ToLower())
			|| name == idName.ToLower() + "_id"
			|| thisIsTheField
			)
			{
				cSharpTypeToUse = idName + "Id";
				return true;
			}
			return false;
		}

	}

}
