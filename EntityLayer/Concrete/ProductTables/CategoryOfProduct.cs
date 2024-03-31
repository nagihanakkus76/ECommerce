using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ProductTables
{
    public class CategoryOfProduct : BaseEntity
    {
        public int? CategoryID { get; set; }
        public int? ProductID { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Product? Product { get; set; }
    }
}