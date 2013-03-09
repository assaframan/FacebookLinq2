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
    /// https://developers.facebook.com/docs/reference/fql/score
    /// </summary>
    [Table(Name = "score")]
    public class Score
    {
        /// <summary>
        /// The App ID of the game where the score is achieved
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "app_id" , IsPrimaryKey = true)]
        public AppId AppId { get; set; }

        /// <summary>
        /// The user ID who holds the scores
        /// 
        /// original type is: numeric string
        /// </summary>
        [Column(Name = "user_id" )]
        public Uid UserId { get; set; }

        /// <summary>
        /// Array of scores of the user being queried
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "value" )]
        public object Value { get; set; }

    }
}
