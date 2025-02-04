﻿using OnlineShopDuhootWeb.Areas.Identity.Data;
using System.Linq;

namespace OnlineShopDuhootWeb.Areas.Repositories.Abstract
{
    public interface IProductRepository
    {
        public void SaveProduct(Product entity);
        public Product CreateNewProduct();
        public void DeleteProduct(int id);
        public IQueryable<Product> Products { get; }
        public Product GetProductById(int id);
    }
}
