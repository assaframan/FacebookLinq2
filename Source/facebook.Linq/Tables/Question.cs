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
    /// http://developers.facebook.com/docs/reference/fql/question/
    /// </summary>
    [Table(Name = "question")]
    public class Question
    {
        /// <summary>
        /// The question ID
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public long? Id { get; set; }

        /// <summary>
        /// ID of the user who created the question
        /// 
        /// original type is: int
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
        /// Time the question was created, expressed as a UNIX timestamp
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "created_time" )]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// Time the question was was last modified, expressed as a UNIX timestamp
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "updated_time" )]
        public long? UpdatedTime { get; set; }

    }
}
