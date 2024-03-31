using EntityLayer.Concrete.ProductTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ProductTabless
{
    public class ProductAttribute : BaseEntity
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public int? ProductID { get; set; }
        public virtual Product? Product { get; set; }
    }
}