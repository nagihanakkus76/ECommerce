using EntityLayer.Concrete.ProductTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.SellerTables
{
    public class SellerOfProduct : BaseEntity
    {
        public int? ProductID { get; set; }
        public int? SellerID { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Seller? Seller { get; set; }
    }
}