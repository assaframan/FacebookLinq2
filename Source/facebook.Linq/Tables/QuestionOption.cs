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
    /// https://developers.facebook.com/docs/reference/fql/question_option
    /// </summary>
    [Table(Name = "question_option")]
    public class QuestionOption
    {
        /// <summary>
        /// UNIX timestamp of time when the option was created
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created_time" , IsPrimaryKey = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// ID of the specific question option
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "id" )]
        public QuestionOptionId Id { get; set; }

        /// <summary>
        /// Text of the option
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// ID of the Page associated with this option (optional, may be empty)
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "object_id" )]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// User ID of the owner
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// ID of the photo associated with this option (optional, may be empty)
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "photo_id" )]
        public PhotoId PhotoId { get; set; }

        /// <summary>
        /// ID of the question associated with this option
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "question_id" )]
        public object QuestionId { get; set; }

        /// <summary>
        /// Number of votes this option has received
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "votes" )]
        public object Votes { get; set; }

    }
}
