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
    /// https://developers.facebook.com/docs/reference/fql/question
    /// </summary>
    [Table(Name = "question")]
    public class Question
    {
        /// <summary>
        /// Time the question was created (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created_time" , IsPrimaryKey = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The question ID
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "id" )]
        public QuestionId Id { get; set; }

        /// <summary>
        /// Whether the question has been published
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_published" )]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// ID of the user who created the question
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// Text of the question
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "question" )]
        public string Question_ { get; set; }

        /// <summary>
        /// Time the question was was last modified (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

    }
}
