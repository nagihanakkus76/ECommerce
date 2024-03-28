using EntityLayer.Concrete.AddressTables;
using EntityLayer.Concrete.CommentRatingTables;
using EntityLayer.Concrete.PaymentTables;
using EntityLayer.Concrete.ShippingTables;
using EntityLayer.Concrete.UserTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.OrderTables
{
    public class Order : BaseEntity
    {
        public int? OrderNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? TotalAmount { get; set; }
        public int? UserID { get; set; }
        public int? UserAddressID { get; set; }
        public int? OrderStatusTypeID { get; set; }
        public User? User { get; set; }
        public UserAddress? UserAddress { get; set; }
        public OrderStatusType? OrderStatusType { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public List<PaymentOfOrder> PaymentOrders { get; set; } = new List<PaymentOfOrder>();
        public List<SellerRating> SellerRatings { get; set; } = new List<SellerRating>();
        public List<Shipping> Shippings { get; set; } = new List<Shipping>();
    }
}