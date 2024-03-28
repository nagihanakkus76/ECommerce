using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ProductTables
{
    public class ProductImage : BaseEntity
    {
        public string? Url { get; set; }
        public int? ProductID { get; set; }
        public Product? Product { get; set; }
    }
}