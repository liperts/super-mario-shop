﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }

        public static implicit operator Category(Dictionary<string, Category> v)
        {
            throw new NotImplementedException();
        }
    }
}