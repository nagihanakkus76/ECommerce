using EntityLayer.Concrete.OrderTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ShippingTables
{
    public class Shipping : BaseEntity
    {
        public int? OrderID { get; set; }
        public int? ShippingCompanyID { get; set; }
        public string? TrackingNumber { get; set; }
        public DateTime? ShipmentDate { get; set;}
        public DateTime? EstimatedDeliveryDate { get; set;}
        public DateTime? DeliveryDate { get; set;}
        public virtual Order? Order { get; set; }
        public virtual ShippingCompany? ShippingCompany { get; set; }
    }
}