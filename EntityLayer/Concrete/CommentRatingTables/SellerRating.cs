using EntityLayer.Concrete.OrderTables;
using EntityLayer.Concrete.UserTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.CommentRatingTables
{
    public class SellerRating : BaseEntity
    {
        public int? OrderID { get; set; }
        public int? UserID { get; set; }
        public int? RatingTypeID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public User? User { get; set; }
        public RatingType? RatingType { get; set; }
        public Order? Order { get; set; }
        public List<SellerComment> SellerComments { get; set; } = new List<SellerComment>();
    }
}