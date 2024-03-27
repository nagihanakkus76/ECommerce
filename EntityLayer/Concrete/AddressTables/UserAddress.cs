using EntityLayer.Concrete.UserContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class UserAddress : BaseEntity
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public Quarter Quarter { get; set; }
        public int QuarterID { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
