﻿using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    interface IProductService
    {
        event Action onChange;

        List<Product> Products { get; set; }

        Task LoadProducts(string categoryUrl = null);

        Task<Product> GetProduct(int id);
    }
}
