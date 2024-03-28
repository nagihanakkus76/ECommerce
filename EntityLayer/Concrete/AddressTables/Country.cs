using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class Country : BaseEntity
    {
        public string? Name { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}