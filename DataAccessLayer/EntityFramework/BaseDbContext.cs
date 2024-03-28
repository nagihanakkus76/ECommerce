using EntityLayer.Concrete.AddressTables;
using EntityLayer.Concrete.CommentRatingTables;
using EntityLayer.Concrete.Favorites;
using EntityLayer.Concrete.OrderTables;
using EntityLayer.Concrete.PaymentTables;
using EntityLayer.Concrete.ProductTables;
using EntityLayer.Concrete.ProductTabless;
using EntityLayer.Concrete.SellerTables;
using EntityLayer.Concrete.ShippingTables;
using EntityLayer.Concrete.UserTables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class BaseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0P2BI1D;initial catalog=E-CommerceDb;integrated Security=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CartDetail> CartDetails { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryOfProduct> CategoryOfProducts { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderStatusType> OrderStatusTypes { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<PaymentOfOrder> PaymentOfOrders { get; set; }

        public DbSet<PaymentType> PaymentTypes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductAttribute> ProductAttributes { get; set; }

        public DbSet<ProductComment> ProductComments { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<ProductRating> ProductRatings { get; set; }

        public DbSet<SellerOfProduct> SellerOfProducts { get; set; }

        public DbSet<ProductVideo> ProductVideos { get; set; }

        public DbSet<Quarter> Quarters { get; set; }

        public DbSet<RatingType> RatingTypes { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<SellerComment> SellerComments { get; set; }

        public DbSet<SellerRating> SellerRatings { get; set; }

        public DbSet<Shipping> Shippings { get; set; }

        public DbSet<ShippingCompany> ShippingCompanies { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserAddress> UserAddresses { get; set; }

    }
}
