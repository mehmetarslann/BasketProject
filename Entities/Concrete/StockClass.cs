using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SepetStokProject.Entities
{
    public class StockClass : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StockCount { get; set; }
    }
}
