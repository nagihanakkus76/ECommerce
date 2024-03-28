using EntityLayer.Concrete.ProductTables;
using EntityLayer.Concrete.UserTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.OrderTables
{
    public class CartDetail : BaseEntity
    {
        public int? ProductID { get; set; }
        public int? UserID { get; set; }
        public int? Piece { get; set; }
        public User? User { get; set; }
        public Product? Product { get; set; }
    }
}