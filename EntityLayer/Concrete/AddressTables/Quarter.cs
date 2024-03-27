using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class Quarter : BaseEntity
    {
        public string Name { get; set; }
        public District District { get; set; }
        public int DistrictID { get; set; }
    }
}