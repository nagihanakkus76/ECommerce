using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.UserTables
{
    public class Gender : BaseEntity
    {
        public string? Name { get; set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}