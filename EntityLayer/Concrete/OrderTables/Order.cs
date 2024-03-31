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
        public virtual User? User { get; set; }
        public virtual UserAddress? UserAddress { get; set; }
        public virtual OrderStatusType? OrderStatusType { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public virtual ICollection<PaymentOfOrder> PaymentOrders { get; set; } = new List<PaymentOfOrder>();
        public virtual ICollection<SellerRating> SellerRatings { get; set; } = new List<SellerRating>();
        public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();
    }
}