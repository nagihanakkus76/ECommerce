using EntityLayer.Concrete.OrderTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.PaymentTables
{
    public class PaymentOfOrder : BaseEntity
    {
        public int? PaymentID { get; set; }
        public int? OrderID { get; set; }
        public Payment? Payment { get; set; }
        public Order? Order { get; set; }
    }
}