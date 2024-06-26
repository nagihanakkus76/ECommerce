﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.CommentRatingTables
{
    public class ProductComment : BaseEntity
    {
        public int? ProductRatingID { get; set; }
        public string? Detail { get; }
        public virtual ProductRating? ProductRating { get; set; }
    }
}