using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ProductTables
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public int? ParentCategoryID { get; set; }
        public virtual ICollection<CategoryOfProduct> CategoryOfProducts { get; set; } = new List<CategoryOfProduct>();
    }
}