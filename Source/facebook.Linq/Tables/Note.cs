using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/notes/
    /// </summary>
    [Table(Name = "note")]
    public class Note
    {
        /// <summary>
        /// The user ID of the current user.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "uid" , IsPrimaryKey = true)]
        public long Uid { get; set; }

        /// <summary>
        /// The unique identifier for the note.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "note_id" )]
        public string NoteId { get; set; }

        /// <summary>
        /// The time the user created the note as a UNIX timestamp.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The most recent time the user edited the note as a UNIX timestamp.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime UpdatedTime { get; set; }

        /// <summary>
        /// The body of the note in plaintext.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "content" )]
        public string Content { get; set; }

        /// <summary>
        /// The body of the note with HTML tags.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "content_html" )]
        public string ContentHtml { get; set; }

        /// <summary>
        /// The title of the note.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The like information of the note being queried. This is an object containing <code>can_like</code>, <code>like_count</code>, and <code>user_likes</code>
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "like_info" )]
        public string LikeInfo { get; set; }

        /// <summary>
        /// The comment information of the note being queried. This is an object containing <code>can_comment</code> and <code>comment_count</code>
        /// 
        /// original type is: object
        /// </summary>
        [Column(Name = "comment_info" )]
        public string CommentInfo { get; set; }

    }
}
