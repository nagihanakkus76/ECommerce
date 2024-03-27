using EntityLayer.Concrete.ProductContainer;
using EntityLayer.Concrete.UserContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Favorites
{
    public class Favorite : BaseEntity
    {
        public Product Product { get; set; }
        public int ProductID { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
