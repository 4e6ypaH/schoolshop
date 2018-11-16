﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
