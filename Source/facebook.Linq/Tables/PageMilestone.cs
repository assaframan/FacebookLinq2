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
    /// https://developers.facebook.com/docs/reference/fql/page_milestone
    /// </summary>
    [Table(Name = "page_milestone")]
    public class PageMilestone
    {
        /// <summary>
        /// The creation time of the milestone (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "created_time" , IsPrimaryKey = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The description of the milestone
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The end time of a milestone (UNIX timestamp). Page milestones have the same start_time and end_time
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "end_time" )]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The ID of the milestone
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "id" )]
        public MilestoneId Id { get; set; }

        /// <summary>
        /// Whether the milestone is hidden
        /// 
        /// original type is: bool
        /// </summary>
        [Column(Name = "is_hidden" )]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// The ID of the page that this milestone belongs to
        /// 
        /// original type is: id
        /// </summary>
        [Column(Name = "owner_id" )]
        public PageId OwnerId { get; set; }

        /// <summary>
        /// The start time of a milestone (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "start_time" )]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The title of the milestone
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The time the milestone was last updated (UNIX timestamp)
        /// 
        /// original type is: timestamp
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime? UpdatedTime { get; set; }

    }
}
