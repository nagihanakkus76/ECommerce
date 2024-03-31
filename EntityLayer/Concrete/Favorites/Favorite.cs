using EntityLayer.Concrete.ProductTables;
using EntityLayer.Concrete.UserTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Favorites
{
    public class Favorite : BaseEntity
    {
        public int? ProductID { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
    }
}