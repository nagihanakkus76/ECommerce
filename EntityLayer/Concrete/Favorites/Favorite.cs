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
        public Product? Product { get; set; }
        public User? User { get; set; }
    }
}