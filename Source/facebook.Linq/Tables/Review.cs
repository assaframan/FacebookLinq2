using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/review/
    /// </summary>
    [Table(Name = "review")]
    public class Review
    {
        /// <summary>
        /// The ID of the application to which a review applies.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "reviewee_id" , IsPrimaryKey = true)]
        public long RevieweeId { get; set; }

        /// <summary>
        /// The ID of the user who created a review.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "reviewer_id" )]
        public long ReviewerId { get; set; }

        /// <summary>
        /// The ID of the review.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "review_id" )]
        public long ReviewId { get; set; }

        /// <summary>
        /// The review text (optional).
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// A Unix timestamp associated with the creation time of a review.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "created_time" )]
        public long CreatedTime { get; set; }

        /// <summary>
        /// The review rating.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "rating" )]
        public long Rating { get; set; }

    }
}
