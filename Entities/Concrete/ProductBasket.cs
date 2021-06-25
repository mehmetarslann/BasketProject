using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SepetStokProject.Entities
{
    public class ProductsBasket: IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int UserID { get; set; }


    }
}
