using fruitpal.DataAccess;
using fruitpal.Model;
using fruitpal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fruitpal.Logic
{
    public class FruitCommodityLogic : ICommodityLogic<int, int, List<CostResult>>
    {
        private IFlatFileData<CountryCommodity> countryCommodityData;
        private ICalculatorService<CostElement, CostResult> costCalculatorService;

        public FruitCommodityLogic()
        {
            countryCommodityData = new CountryCommodityData();
            costCalculatorService = new CostCalculatorService();
        }

        public List<CostResult> GetCommodityPrices(string commodity, int price, int quantity)
        {
            return countryCommodityData.GetDataMatchingSpecifiedFilter(commodity).Select(countryCommodity => new CostElement() 
                { 
                    Price = price,
                    Quantity = quantity,
                    Commodity = countryCommodity
                })
            .Select(costElement => costCalculatorService.Calculate(costElement))
            .OrderByDescending(costResult => costResult.GrandTotal).ToList();
        }
    }
}
