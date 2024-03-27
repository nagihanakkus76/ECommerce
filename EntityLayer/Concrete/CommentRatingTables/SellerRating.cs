using EntityLayer.Concrete.OrderTables;
using EntityLayer.Concrete.UserContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.CommentRatingTables
{
    public class SellerRating : BaseEntity
    {
        public Order Order { get; set; }
        public int OrderID { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public RatingType RatingType { get; set; }
        public int RatingTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
