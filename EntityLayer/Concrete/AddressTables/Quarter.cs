using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class Quarter : BaseEntity
    {
        public string? Name { get; set; }
        public int? DistrictID { get; set; }
        public virtual District? District { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();
    }
}