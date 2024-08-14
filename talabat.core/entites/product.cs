﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talabat.core.entites
{
    public class product:BaseClass
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public int productBrandId { get; set; }
        public ProductBrand productBrand { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

    }

}
