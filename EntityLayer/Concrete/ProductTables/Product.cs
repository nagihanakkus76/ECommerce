using EntityLayer.Abstract;
using EntityLayer.Concrete.CommentRatingTables;
using EntityLayer.Concrete.Favorites;
using EntityLayer.Concrete.OrderTables;
using EntityLayer.Concrete.ProductTabless;
using EntityLayer.Concrete.SellerTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ProductTables
{
    public class Product : BaseEntity, IBaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
        public virtual ICollection<CategoryOfProduct> CategoryOfProducts { get; set; } = new List<CategoryOfProduct>();
        public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public virtual ICollection<ProductRating> ProductRatings { get; set; } = new List<ProductRating>();
        public virtual ICollection<SellerOfProduct> ProductSellers { get; set; } = new List<SellerOfProduct>();
        public virtual ICollection<ProductVideo> ProductVideos { get; set; } = new List<ProductVideo>();
    }
}