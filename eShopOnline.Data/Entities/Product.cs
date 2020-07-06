﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }
    }
}
