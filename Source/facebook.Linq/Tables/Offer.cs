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
    /// http://developers.facebook.com/docs/reference/fql/offer/
    /// </summary>
    [Table(Name = "offer")]
    public class Offer
    {
        /// <summary>
        /// The ID of the offer.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "id" , IsPrimaryKey = true)]
        public OfferId Id { get; set; }

        /// <summary>
        /// The ID of the Page that this offer belongs to.
        /// 
        /// original type is: int
        /// Indexable
        /// </summary>
        [Column(Name = "owner_id" )]
        public PageId OwnerId { get; set; }

        /// <summary>
        /// The title of the offer.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "title" )]
        public string Title { get; set; }

        /// <summary>
        /// The URL of the image for the offer.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "image_url" )]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Text description of the terms under which the offer can be claimed.
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "terms" )]
        public string Terms { get; set; }

        /// <summary>
        /// The maximum number of times the offer can be claimed.
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "claim_limit" )]
        public long? ClaimLimit { get; set; }

        /// <summary>
        /// The UNIX timestamp when the offer was created
        /// 
        /// original type is: int
        /// </summary>
        [Column(Name = "created_time" )]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The UNIX timestamp when the offer expires (this is only for display purposes).
        /// 
        /// original type is: string
        /// </summary>
        [Column(Name = "expiration_time" )]
        public DateTime? ExpirationTime { get; set; }

    }
}
