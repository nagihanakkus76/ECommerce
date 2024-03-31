using EntityLayer.Abstract;
using EntityLayer.Concrete.AddressTables;
using EntityLayer.Concrete.CommentRatingTables;
using EntityLayer.Concrete.Favorites;
using EntityLayer.Concrete.OrderTables;
using EntityLayer.Concrete.SellerTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.UserTables
{
    public class User : BaseEntity, IBaseEntity
    {
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? GenderID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Status { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
        public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<ProductRating> ProductRatings { get; set; } = new List<ProductRating>();
        public virtual ICollection<SellerRating> SellerRatings { get; set; } = new List<SellerRating>();
        public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();
    }
}