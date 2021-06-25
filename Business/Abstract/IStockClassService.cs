using SepetStokProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStockClassService
    {
        List<StockClass> GetAll();
        StockClass GetStockByProductId(int productId);
        bool AddStockByProductId(int ProductId, int StockCount);
    }
}
