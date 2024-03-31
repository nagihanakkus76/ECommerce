using EntityLayer.Concrete.AddressTables;
using EntityLayer.Concrete.UserTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.SellerTables
{
    public class Seller : BaseEntity
    {
        public int? UserID { get; set; }
        public int? UserAddressID { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxNumber { get; set; }
        public string? CompanyType { get; set; }
        public virtual User? User { get; set; }
        public virtual UserAddress? UserAddress { get; set; }
        public virtual ICollection<SellerOfProduct> ProductSellers { get; set; } = new List<SellerOfProduct>();
    }
}