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
            throw new NotImplementedException();
        }
    }
}
