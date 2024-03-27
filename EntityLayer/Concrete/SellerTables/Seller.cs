using EntityLayer.Concrete.AddressTables;
using EntityLayer.Concrete.UserContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.SellerTables
{
    public class Seller : BaseEntity
    {
        public User User { get; set; }
        public int UserID { get; set; }
        public UserAddress UserAddress { get; set; }
        public int UserAddressID { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyType { get; set; }
    }
}
