using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/question_option_votes/
    /// </summary>
    [Table(Name = "question_option_votes")]
    public class QuestionOptionVotes
    {
        /// <summary>
        /// ID of the option associated with these votes
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "option_id" , IsPrimaryKey = true)]
        public long OptionId { get; set; }

        /// <summary>
        /// ID of the user who submitted the vote
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "voter_id" )]
        public long VoterId { get; set; }

    }
}
