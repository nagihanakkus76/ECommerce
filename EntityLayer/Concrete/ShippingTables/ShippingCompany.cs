﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ShippingTables
{
    public class ShippingCompany : BaseEntity
    {
        public string? Name { get; set; }
        public  List<Shipping> Shippings { get; set; } = new List<Shipping>();
    }
}