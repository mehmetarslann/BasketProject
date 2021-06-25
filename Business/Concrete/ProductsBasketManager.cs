using BasketProject.Business.Abstract;
using DataAccess.Abstract;
using SepetStokProject.Entities;
using System.Collections.Generic;

namespace BasketProject.Business.Concrete
{
    public class ProductsBasketManager : IProductsBasketService
    {
        private IProductsBasketDal _productDal;

        public ProductsBasketManager(IProductsBasketDal productDal)
        {
            _productDal = productDal;
        }

        public bool AddProductByCount(ProductsBasket entity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteByProductId(int UserId, int ProductId, int ProductCountForDelete)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductsBasket> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<ProductsBasket> GetBasketDataByUserId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
