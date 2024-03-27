using EntityLayer.Concrete.AddressTables;
using EntityLayer.Concrete.UserContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.OrderTables
{
    public class Order : BaseEntity
    {
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public UserAddress UserAddress { get; set; }
        public int UserAddressID { get; set; }
        public OrderStatusType OrderStatusType { get; set; }
        public int OrderStatusTypeID { get; set; }
    }
}