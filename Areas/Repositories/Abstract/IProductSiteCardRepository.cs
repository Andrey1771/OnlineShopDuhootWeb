﻿using System.Linq;
using OnlineShopDuhootWeb.Areas.Identity.Data;

namespace OnlineShopDuhootWeb.Areas.Repositories.Abstract
{
    public interface IProductSiteCardRepository
    {
        
        public void SaveSiteCard(ProductSiteCard entity);
        public ProductSiteCard CreateNewSiteCard(int id);
        public void DeleteSiteCard(int id);
        public IQueryable<ProductSiteCard> ProductSiteCards { get; }
        public ProductSiteCard GetSiteCardById(int id);
    }
}
