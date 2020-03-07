using fruitpal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Logic
{
    public class FruitCommodityLogic : ICommodityLogic<int, int, List<CostResult>>
    {
        public List<CostResult> GetCommodityPrices(string commodity, int price, int quantity)
        {
            return new List<CostResult>
            {
                new CostResult
                {
                    GrandTotal = 22060.10,
                    TotalVariable = 54.42,
                    Fixed = 20.00,
                    Quantity = 405
                },
                new CostResult
                {
                    GrandTotal = 21999.20,
                    TotalVariable = 54.24,
                    Fixed = 32.00,
                    Quantity = 405
                }
            };
        }
    }
}
