using SepetStokProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketProject.Business.Abstract
{
   public interface IProductsBasketService
    {
        List<ProductsBasket> GetAll();
        List<ProductsBasket> GetBasketDataByUserId(int id);
        bool AddProductByCount(ProductsBasket entity);
        bool DeleteByProductId(int UserId, int ProductId, int ProductCountForDelete);
    }
}
