using fruitpal.Constant;
using fruitpal.Logic;
using fruitpal.Model;
using System;
using System.Collections.Generic;

namespace fruitpal
{
    class Program
    {
        static int Main(string[] args)
        {
            //Args length check
            if(args.Length != 3)
            {
                Console.WriteLine(Constants.VALID_NO_PARAMETERS);
                return 1;
            }

            //Parameter initialization and validation
            string commodity = args[0];
            int price, quantity;

            bool isPriceValid = int.TryParse(args[1], out price) && price >= 0;
            bool isQuantityValid = int.TryParse(args[2], out quantity) && quantity >= 0;
            
            if(!isPriceValid || !isQuantityValid)
            {
                Console.WriteLine(Constants.VALID_INT_PARAMETERS);
                return 1;
            }

            ICommodityLogic<int, int, List<CostResult>> fruitCommodityLogic = new FruitCommodityLogic();

            //Call orchestrating business logic and write results
            fruitCommodityLogic.GetCommodityPrices(commodity, price, quantity).ForEach(Console.WriteLine);
            return 0;
        }
    }
}
