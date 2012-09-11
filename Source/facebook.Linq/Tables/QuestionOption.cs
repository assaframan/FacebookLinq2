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
    /// http://developers.facebook.com/docs/reference/fql/question_option/
    /// </summary>
    [Table(Name = "question_option")]
    public class QuestionOption
    {
        /// <summary>
        /// ID of the specific question option
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public long? Id { get; set; }

        /// <summary>
        /// ID of the question associated with this option.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "question_id" )]
        public string QuestionId { get; set; }

        /// <summary>
        /// Text of the option
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "name" )]
        public string Name { get; set; }

        /// <summary>
        /// Number of votes this option has received
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "votes" )]
        public long? Votes { get; set; }

        /// <summary>
        /// ID of Page associated with this option (optional, may be empty)
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "object_id" )]
        public long? ObjectId { get; set; }

        /// <summary>
        /// User ID of the owner
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "owner" )]
        public Uid Owner { get; set; }

        /// <summary>
        /// UNIX timestamp of time when the option was created
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "created_time" )]
        public long? CreatedTime { get; set; }

    }
}
