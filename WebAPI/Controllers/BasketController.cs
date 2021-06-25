using BasketProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using SepetStokProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        IProductsBasketService _productService;

        public BasketController(IProductsBasketService productService)
        {
            _productService = productService;
        }

        private readonly List<ProductsBasket> productsBaskets;

        [HttpPost]
        public void AddBasket(ProductsBasket product)
        {
            List<ProductsBasket> productList = _productService.GetAll();
            var result = productList.Where(x => x.ProductId == product.ProductId).Count();

            if (result > 0)
            {
                productsBaskets.Add(product);
            }
        }
    }
}
