﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.AddressTables
{
    public class District : BaseEntity
    {
        public string Name { get; set; }
        public City City { get; set; }
        public City CityID { get; set; }
    }
}