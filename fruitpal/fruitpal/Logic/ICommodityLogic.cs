using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Logic
{
    public interface ICommodityLogic<T, K, U>
    {
        public U GetCommodityPrices(string commodity, T price, K quantity);
    }
}
