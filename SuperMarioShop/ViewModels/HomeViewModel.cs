﻿using SuperMarioShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> PreferredProducts { get; set; }
    }
}
