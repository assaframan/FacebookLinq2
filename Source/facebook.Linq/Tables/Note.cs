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
    /// https://developers.facebook.com/docs/reference/fql/note
    /// </summary>
    [Table(Name = "note")]
    public class Note
    {
        /// <summary>
        /// The comment information of the note being queried. This is an object containing can_comment and comment_count.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "comment_info" , IsPrimaryKey = true)]
        public CommentInfo CommentInfo { get; set; }

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
        /// The time the user created the note as a UNIX timestamp.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The like information of the note being queried. This is an object containing can_like, like_count, and user_likes.
        /// 
        /// original type is: struct
        /// </summary>
        [Column(Name = "like_info" )]
        public LikeInfo LikeInfo { get; set; }

        /// <summary>
        /// The unique identifier for the note.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "note_id" )]
        public string NoteId { get; set; }

        /// <summary>
        /// The title of the note.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The user ID of the current user.
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "uid" )]
        public Uid Uid { get; set; }

        /// <summary>
        /// Cursor for the uid field.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "uid_cursor" )]
        public string UidCursor { get; set; }

        /// <summary>
        /// The most recent time the user edited the note as a UNIX timestamp.
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

    }
}
