using fruitpal.Logic;
using fruitpal.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fruitpalTests.LogicTests
{
    [TestClass]
    public class FruitCommodityLogicTests
    {
        private FruitCommodityLogic fruitCommodityLogic;

        [TestInitialize]
        public void SetUp()
        {
            fruitCommodityLogic = new FruitCommodityLogic();
        }

        [TestMethod]
        public void Get_Commodity_Prices_ValidInput_ReturnsList()
        {
            string commodity = "mango";
            int price = 53;
            int quantity = 405;

            List<CostResult> expected = new List<CostResult>
            {
                new CostResult
                {
                    Country = "BR",
                    GrandTotal = 22060.10,
                    TotalVariable = 54.42,
                    Fixed = 20.00,
                    Quantity = 405
                },
                new CostResult
                {
                    Country = "MX",
                    GrandTotal = 21999.20,
                    TotalVariable = 54.24,
                    Fixed = 32.00,
                    Quantity = 405
                }
            };

            List<CostResult> actual = fruitCommodityLogic.GetCommodityPrices(commodity, price, quantity);

            Assert.IsTrue(expected.SequenceEqual(actual), "The expected list of commodity prices did not match the actual list of commodity prices");
        }
    }
}
