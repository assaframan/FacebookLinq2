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
    /// https://developers.facebook.com/docs/reference/fql/link_stat
    /// </summary>
    [Table(Name = "link_stat")]
    public class LinkStat
    {
        /// <summary>
        /// The number of times Facebook users have clicked a link to the page from a share or like
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "click_count" , IsPrimaryKey = true)]
        public object ClickCount { get; set; }

        /// <summary>
        /// The number of comments users have made on the shared story
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "comment_count" )]
        public object CommentCount { get; set; }

        /// <summary>
        /// The object_id associated with comments plugin comments for this URL. This can be used to query for comments using the comment FQL table
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "comments_fbid" )]
        public object CommentsFbid { get; set; }

        /// <summary>
        /// The number of comments from a <a href="/docs/reference/plugins/comments/">comments plugin</a> on this URL. This only includestop level comments, not replies
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "commentsbox_count" )]
        public object CommentsboxCount { get; set; }

        /// <summary>
        /// The number of times Facebook users have "Liked" the page, or liked any comments or re-shares of this page
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "like_count" )]
        public object LikeCount { get; set; }

        /// <summary>
        /// The normalized URL for the page being shared
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "normalized_url" )]
        public string NormalizedUrl { get; set; }

        /// <summary>
        /// The number of times users have shared the page on Facebook
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "share_count" )]
        public object ShareCount { get; set; }

        /// <summary>
        /// The total number of times the URL has been shared, liked, or commented on
        /// 
        /// original type is: number
        /// </summary>
        [Column(Name = "total_count" )]
        public object TotalCount { get; set; }

        /// <summary>
        /// URL of the web page users can share
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "url" )]
        public string Url { get; set; }

    }
}
