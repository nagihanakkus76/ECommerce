using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class District : BaseEntity
    {
        public string? Name { get; set; }
        public int? CityID { get; set; }
        public virtual City? City { get; set; }
        public virtual ICollection<Quarter> Quarters { get; set; } = new List<Quarter>();
    }
}