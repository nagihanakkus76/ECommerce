using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.CommentRatingTables
{
    public class ProductComment : BaseEntity
    {
        public ProductRating ProductRating { get; set; }
        public int ProductRatingID { get; set; }
        public string Detail { get; }
    }
}
