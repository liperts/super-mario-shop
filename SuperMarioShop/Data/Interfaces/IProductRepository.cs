﻿using SuperMarioShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> PreferredProducts { get; }
        Product GetProductById(int productId);
    }
}
