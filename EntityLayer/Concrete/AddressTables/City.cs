using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class City : BaseEntity
    {
        public string? Name { get; set; }
        public int? CountryID { get; set; }
        public virtual Country? Country { get; set; }
        public virtual ICollection<District> Districts { get; set; } = new List<District>();
    }
}