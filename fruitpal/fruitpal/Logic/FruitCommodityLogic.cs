using fruitpal.DataAccess;
using fruitpal.Model;
using fruitpal.Services;
using System.Collections.Generic;
using System.Linq;

namespace fruitpal.Logic
{
    public class FruitCommodityLogic : ICommodityLogic<int, int, List<CostResult>>
    {
        private IFlatFileData<CountryCommodity> CountryCommodityData;
        private ICalculatorService<CostElement, CostResult> CostCalculatorService;

        /// <summary>
        /// Constructor
        /// </summary>
        public FruitCommodityLogic(IFlatFileData<CountryCommodity> countryCommodityData, ICalculatorService<CostElement, CostResult> calculatorService)
        {
            CountryCommodityData = countryCommodityData;
            CostCalculatorService = calculatorService;
        }

        /// <summary>
        /// Orchestrating business logic for retrieval of commodity prices.
        /// Calls data access object for data retrieval as List of CountryCommodity.
        /// Calculates cost for CountryCommodity objects and returns results.
        /// </summary>
        /// <param name="commodity"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public List<CostResult> GetCommodityPrices(string commodity, int price, int quantity)
        {
            return CountryCommodityData.GetDataMatchingSpecifiedFilter(commodity).Select(countryCommodity => new CostElement() 
                { 
                    Price = price,
                    Quantity = quantity,
                    Commodity = countryCommodity
                })
            .Select(costElement => CostCalculatorService.Calculate(costElement))
            .OrderByDescending(costResult => costResult.GrandTotal).ToList();
        }
    }
}
