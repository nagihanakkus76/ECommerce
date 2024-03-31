using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.CommentRatingTables
{
    public class RatingType : BaseEntity
    {
        public string? DisplayText { get; set; }
        public double? Score { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; } = new List<ProductRating>();
        public virtual ICollection<SellerRating> SellerRatings { get; set; } = new List<SellerRating>();
    }
}