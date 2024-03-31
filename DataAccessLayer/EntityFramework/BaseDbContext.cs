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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Gender>()
                .HasData(
                new Gender() { ID = 1, Name = "Kadın" },
                new Gender() { ID = 2, Name = "Erkek" });
            modelBuilder.Entity<User>().HasData(
                new User() {ID=1, GenderID=1, FirstName="Ayşe", LastName="Yılmaz", UserName="ayseyılmaz" },
                new User() {ID=2, GenderID=1, FirstName="Ceyda", LastName="Yıldıl", UserName="ceydayıldız" },
                new User() {ID=3, GenderID=2, FirstName="Ali", LastName="Güneş", UserName="aligünes" }
                );

            modelBuilder.Entity<Gender>().Property( x => x.Name).HasMaxLength(10);
            modelBuilder.Entity<PaymentType>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<Payment>().Property( x => x.CardNumber).HasMaxLength(20);
            modelBuilder.Entity<Shipping>().Property( x => x.TrackingNumber).HasMaxLength(50);
            modelBuilder.Entity<ShippingCompany>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<OrderStatusType>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<Quarter>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<District>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<City>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<Country>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<SellerComment>().Property( x => x.Detail).HasMaxLength(500);
            modelBuilder.Entity<ProductComment>().Property( x => x.Detail).HasMaxLength(500);
            modelBuilder.Entity<RatingType>().Property( x => x.DisplayText).HasMaxLength(50);
            modelBuilder.Entity<ProductImage>().Property( x => x.Url).HasMaxLength(500);
            modelBuilder.Entity<ProductVideo>().Property( x => x.Url).HasMaxLength(500);
            modelBuilder.Entity<ProductAttribute>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<ProductAttribute>().Property( x => x.Value).HasMaxLength(50);
            modelBuilder.Entity<Category>().Property( x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property( x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Seller>().Property( x => x.CompanyName).HasMaxLength(100);
            modelBuilder.Entity<Seller>().Property( x => x.CompanyType).HasMaxLength(100);
            modelBuilder.Entity<Seller>().Property( x => x.TaxNumber).HasMaxLength(50);
            modelBuilder.Entity<User>().Property( x => x.UserName).HasMaxLength(50);
            modelBuilder.Entity<User>().Property( x => x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<User>().Property( x => x.LastName).HasMaxLength(50);
            modelBuilder.Entity<User>().Property( x => x.Password).HasMaxLength(50);
            modelBuilder.Entity<User>().Property( x => x.Email).HasMaxLength(50);
            modelBuilder.Entity<User>().Property( x => x.PhoneNumber).HasMaxLength(30);
        }
    }
}
