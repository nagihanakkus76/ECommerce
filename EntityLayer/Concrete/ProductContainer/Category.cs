using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ProductContainer
{
    public class Category : BaseEntity
    {
        /// <summary>
        /// Sor Öğren????????
        /// </summary>
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }
}
