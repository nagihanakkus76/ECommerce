using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.PaymentTables
{
    public class Payment : BaseEntity
    {
        public PaymentType PaymentType { get; set; }
        public int PaymentTypeID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CardNumber { get; set; }
    }
}