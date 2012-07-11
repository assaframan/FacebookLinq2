using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook.Linq;
using System.Data.Linq.Mapping;

namespace facebook.Tables
{
    /// <summary>
    /// http://developers.facebook.com/docs/reference/fql/friend/
    /// </summary>
    [Table(Name = "friend")]
    public class Friend
    {
        /// <summary>
        /// The <code>user</code> ID of the first <code>user</code> in a particular friendship link.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "uid1" , IsPrimaryKey = true)]
        public long Uid1 { get; set; }

        /// <summary>
        /// The <code>user</code> ID of the second <code>user</code> in a particular friendship link.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "uid2" )]
        public long Uid2 { get; set; }

    }
}
