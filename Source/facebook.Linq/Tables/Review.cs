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
    /// http://developers.facebook.com/docs/reference/fql/review/
    /// </summary>
    [Table(Name = "review")]
    public class Review
    {
        /// <summary>
        /// The ID of the application to which a review applies.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "reviewee_id" , IsPrimaryKey = true)]
        public AppId RevieweeId { get; set; }

        /// <summary>
        /// The ID of the user who created a review.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "reviewer_id" )]
        public Uid ReviewerId { get; set; }

        /// <summary>
        /// The ID of the review.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "review_id" )]
        public ReviewId ReviewId { get; set; }

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
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The review rating.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "rating" )]
        public long? Rating { get; set; }

    }
}
