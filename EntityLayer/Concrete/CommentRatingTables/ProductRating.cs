using EntityLayer.Concrete.OrderTables;
using EntityLayer.Concrete.ProductTables;
using EntityLayer.Concrete.UserTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.CommentRatingTables
{
    public class ProductRating : BaseEntity
    {
        public int? ProductID { get; set; }
        public int? UserID { get; set; }
        public int? RatingTypeID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
        public virtual RatingType? RatingType { get; set; }
        public virtual ICollection<ProductComment> ProductComments { get; set; } = new List<ProductComment>();
    }
}