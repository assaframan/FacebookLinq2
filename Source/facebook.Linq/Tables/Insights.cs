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
    /// http://developers.facebook.com/docs/reference/fql/insights/
    /// </summary>
    [Table(Name = "insights")]
    public class Insights
    {
        /// <summary>
        /// The object for which you are retrieving metrics.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "object_id" , IsPrimaryKey = true)]
        public long? ObjectId { get; set; }

        /// <summary>
        /// The usage data to retrieve.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "metric" )]
        public string Metric { get; set; }

        /// <summary>
        /// The end of the period during which the metrics were collected, expressed as a unix time (which should always be midnight, Pacific Daylight Time) or using the function <code>end_time_date()</code> which takes a date string in <code>'YYYY-MM-DD'</code> format.</p>
        /// 
        /// <p><strong>Example:</strong> To obtain data for the 24-hour period starting on September 15th at 00:00 (i.e. 12:00 midnight) and ending on September 16th at 00:00 (i.e. 12:00 midnight), specify 1284620400 as the <code>end_time</code> and 86400 as the <code>period</code>.</p>
        /// 
        /// <p><strong>Note:</strong> end_time should not be specified when querying lifetime metrics.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "end_time" )]
        public long? EndTime { get; set; }

        /// <summary>
        /// The length of the period during which the metrics were collected, expressed in seconds as one of <code>86400</code> (day), <code>604800</code> (week), <code>2592000</code> (month) or <code>0</code> (lifetime) or using the function <code>period()</code> which takes one of the strings <code>day</code>, <code>week</code>, <code>month</code> or <code>lifetime</code>.</p>
        /// 
        /// <p><strong>Note:</strong> Each metric may not have all periods available.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "period" )]
        public long? Period { get; set; }

        /// <summary>
        /// The value of the requested metric.
        /// 
        /// original type is: mixed
        /// </summary>
        [Column(Name = "value" )]
        public object Value { get; set; }

    }
}
