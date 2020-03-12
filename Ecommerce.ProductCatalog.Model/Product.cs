﻿using Microsoft.ServiceFabric.Data;
using System;

namespace Ecommerce.ProductCatalog.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Availability { get; set; }
    }
}
