using DataAccess.Abstract;
using SepetStokProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductsBasketDal
    {

        List<ProductsBasket> _products;
        public InMemoryProductDal()
        {
            _products = new List<ProductsBasket> {
                new ProductsBasket{Id=1,Category="Hediyelik Eşya",Name="Çiçek",Price=5,ProductCount=30,ProductId=2,UserID=5 },
                new ProductsBasket{Id=2,Category="Elektronik",Name="Bilgisayar",Price=5,ProductCount=15105,ProductId=2,UserID=3 },
                new ProductsBasket{Id=3,Category="Elektronik",Name="Telefon",Price=5,ProductCount=2105,ProductId=2,UserID=1 },
                new ProductsBasket{Id=4,Category="Hediyelik Eşya",Name="Bardak",Price=5,ProductCount=15,ProductId=2,UserID=4 }
            };
        }

        public void Add(ProductsBasket entity)
        {
            if (entity.ProductCount > 0)
            {
                _products.Add(entity);
            }
        }

        public void Delete(ProductsBasket entity)
        {
            var result = _products.Where(x => x.ProductId == entity.ProductId).Count();
            if (result > 0)
            {
                _products.Remove(entity);
            }
        }

        public List<ProductsBasket> GetAll()
        {
            return _products;
        }
    }
}
