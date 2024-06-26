﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.CommentRatingTables
{
    public class SellerComment : BaseEntity
    {
        public int? SellerRatingID { get; set; }
        public string? Detail { get; }
        public virtual SellerRating? SellerRating { get; set; }
    }
}