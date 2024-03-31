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
        public virtual Quarter? Quarter { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();
    }
}