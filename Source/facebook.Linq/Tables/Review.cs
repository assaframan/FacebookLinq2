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
    /// https://developers.facebook.com/docs/reference/fql/review
    /// </summary>
    [Table(Name = "review")]
    public class Review
    {
        /// <summary>
        /// Creation time of the review (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created_time" , IsPrimaryKey = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The review text (optional)
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "message" )]
        public string Message { get; set; }

        /// <summary>
        /// The review rating. Ratings can range from 1 - 5
        /// 
        /// original type is: unsigned int32
        /// </summary>
        [Column(Name = "rating" )]
        public object Rating { get; set; }

        /// <summary>
        /// The ID of the review
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "review_id" )]
        public ReviewId ReviewId { get; set; }

        /// <summary>
        /// The ID of the application to which a review applies
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "reviewee_id" )]
        public AppId RevieweeId { get; set; }

        /// <summary>
        /// The ID of the user who created a review
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "reviewer_id" )]
        public Uid ReviewerId { get; set; }

    }
}
