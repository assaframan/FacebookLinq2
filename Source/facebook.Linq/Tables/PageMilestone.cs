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
    /// http://developers.facebook.com/docs/reference/fql/life_event/
    /// </summary>
    [Table(Name = "page_milestone")]
    public class PageMilestone
    {
        /// <summary>
        /// The ID of the milestone.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public long Id { get; set; }

        /// <summary>
        /// The ID of the page that this milestone belongs to.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "owner_id" )]
        public long OwnerId { get; set; }

        /// <summary>
        /// The title of the milestone.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The description of the milestone.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "description" )]
        public string Description { get; set; }

        /// <summary>
        /// The creation time of the milestone (UNIX timestamp).
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The update time of the milestone (UNIX timestamp).
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "updated_time" )]
        public DateTime UpdatedTime { get; set; }

        /// <summary>
        /// The start time of a milestone (UNIX timestamp).
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "start_time" )]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of a milestone (UNIX timestamp). Page milestones have the same <code>start_time</code> and <code>end_time</code>.
        /// 
        /// original type is: time
        /// </summary>
        [Column(Name = "end_time" )]
        public DateTime EndTime { get; set; }

    }
}
