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
    /// http://developers.facebook.com/docs/reference/fql/link_stat/
    /// </summary>
    [Table(Name = "link_stat")]
    public class LinkStat
    {
        /// <summary>
        /// The URL to the Web page users can share with Facebook Share. This is the indexable field in the table, so you must specify it in your query's WHERE clause. To specify more than one URL, you must use the IN operator in the query's WHERE clause.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" , IsPrimaryKey = true)]
        public string Url { get; set; }

        /// <summary>
        /// The normalized URL for the page being shared.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "normalized_url" )]
        public string NormalizedUrl { get; set; }

        /// <summary>
        /// The number of times users have shared the page on Facebook.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "share_count" )]
        public long? ShareCount { get; set; }

        /// <summary>
        /// The number of times Facebook users have "Liked" the page, or liked any comments or re-shares of this page.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "like_count" )]
        public long? LikeCount { get; set; }

        /// <summary>
        /// The number of comments users have made on the shared story.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "comment_count" )]
        public long? CommentCount { get; set; }

        /// <summary>
        /// The total number of times the URL has been shared, liked, or commented on.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "total_count" )]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The number of times Facebook users have clicked a link to the page from a share or like.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "click_count" )]
        public long? ClickCount { get; set; }

        /// <summary>
        /// The object_id associated with comments plugin comments for this url. This can be used to query for comments using the comment FQL table.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "comments_fbid" )]
        public long? CommentsFbid { get; set; }

        /// <summary>
        /// The number of comments from a <a href="http://developers.facebook.com/docs/reference/plugins/comments/">comments box</a> on this URL. This only includes top level comments, not replies.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "commentsbox_count" )]
        public long? CommentsboxCount { get; set; }

    }
}
