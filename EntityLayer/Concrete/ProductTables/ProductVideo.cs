using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ProductTables
{
    public class ProductVideo : BaseEntity
    {
        public string? Url { get; set; }
        public int? ProductID { get; set; }
        public virtual Product? Product { get; set; }
    }
}