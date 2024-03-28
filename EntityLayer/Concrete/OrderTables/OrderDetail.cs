using EntityLayer.Concrete.ProductTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.OrderTables
{
    public class OrderDetail : BaseEntity
    {
        public int? OrdeID { get; set; }
        public int? ProductID { get; set; }
        public int? Piece { get; set; }
        public Decimal? UnitPrice { get; set; }
        public double? DiscountAmount { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}