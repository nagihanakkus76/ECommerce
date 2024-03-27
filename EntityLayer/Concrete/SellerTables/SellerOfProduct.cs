using EntityLayer.Concrete.ProductContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.SellerTables
{
    public class SellerOfProduct : BaseEntity
    {
        public Product Product { get; set; }
        public int ProductID { get; set; }
        public Seller Seller { get; set; }
        public int SellerID { get; set; }
    }
}
