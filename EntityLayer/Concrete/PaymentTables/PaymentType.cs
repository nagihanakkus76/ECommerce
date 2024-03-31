using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.PaymentTables
{
    public class PaymentType : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}