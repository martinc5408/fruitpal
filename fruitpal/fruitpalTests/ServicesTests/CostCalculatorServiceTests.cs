using fruitpal.Model;
using fruitpal.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpalTests.ServicesTests
{
    [TestClass]
    public class CostCalculatorServiceTests
    {
        private CostCalculatorService costCalculatorService;

        [TestInitialize]
        public void SetUp()
        {
            costCalculatorService = new CostCalculatorService();
        }

        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectAmount()
        {
            CostElement costElement = new CostElement
            {
                Price = 53,
                Quantity = 405,
                Commodity = new CountryCommodity
                {
                    Country = "MX",
                    Commodity = "mango",
                    FixedOverhead = 32.00,
                    VariableOverhead = 1.24
                }
            };

            CostResult expected = new CostResult
            {
                Country = "MX",
                GrandTotal = 21999.20,
                TotalVariable = 54.24,
                Fixed = 32.00,
                Quantity = 405
            };

            CostResult actual = costCalculatorService.Calculate(costElement);

            Assert.AreEqual(expected, actual, "The expected cost results did not match the actual cost results");
        }
    }
}
