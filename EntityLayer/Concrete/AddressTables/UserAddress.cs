using EntityLayer.Concrete.OrderTables;
using EntityLayer.Concrete.SellerTables;
using EntityLayer.Concrete.UserTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class UserAddress : BaseEntity
    {
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public int? QuarterID { get; set; }
        public int? UserID { get; set; }
        public Quarter? Quarter { get; set; }
        public User? User { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();
    }
}