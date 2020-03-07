using fruitpal.DataAccess;
using fruitpal.Logic;
using fruitpal.Model;
using fruitpal.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fruitpalTests.LogicTests
{
    [TestClass]
    public class FruitCommodityLogicTests
    {
        private FruitCommodityLogic fruitCommodityLogic;
        private Mock<IFlatFileData<CountryCommodity>> mockData;
        private Mock<ICalculatorService<CostElement, CostResult>> mockCalculator;
        private List<CountryCommodity> countryCommodities;
        private CostResult mxResult;
        private CostResult brResult;
        private string mango;
        private string mx;
        private string br;

        [TestInitialize]
        public void SetUp()
        {
            mango = "mango";
            mx = "MX";
            br = "BR";

            countryCommodities = new List<CountryCommodity>
            {
                new CountryCommodity
                {
                    Country = mx,
                    Commodity = mango,
                    FixedOverhead = 32.00,
                    VariableOverhead = 1.24
                },
                new CountryCommodity
                {
                    Country = br,
                    Commodity = mango,
                    FixedOverhead = 20.00,
                    VariableOverhead = 1.42
                }
            };

            mxResult = new CostResult
            {
                Country = mx,
                GrandTotal = 21999.20,
                TotalVariable = 54.24,
                Fixed = 32.00,
                Quantity = 405
            };

            brResult = new CostResult
            {
                Country = br,
                GrandTotal = 22060.10,
                TotalVariable = 54.42,
                Fixed = 20.00,
                Quantity = 405
            };

            mockData = new Mock<IFlatFileData<CountryCommodity>>();
            mockData.Setup(data => data.GetDataMatchingSpecifiedFilter(mango)).Returns(countryCommodities);
            mockCalculator = new Mock<ICalculatorService<CostElement, CostResult>>();
            mockCalculator.Setup(calc => calc.Calculate(It.Is<CostElement>(elem => elem.Commodity.Country.Equals(mx) && elem.Commodity.Commodity.Equals(mango)))).Returns(mxResult);
            mockCalculator.Setup(calc => calc.Calculate(It.Is<CostElement>(elem => elem.Commodity.Country.Equals(br) && elem.Commodity.Commodity.Equals(mango)))).Returns(brResult);

            fruitCommodityLogic = new FruitCommodityLogic(mockData.Object, mockCalculator.Object);
        }

        [TestMethod]
        public void Get_Commodity_Prices_ValidInput_ReturnsList()
        {
            string commodity = mango;
            int price = 53;
            int quantity = 405;

            List<CostResult> expected = new List<CostResult>
            {
                brResult, mxResult
            };

            List<CostResult> actual = fruitCommodityLogic.GetCommodityPrices(commodity, price, quantity);

            Assert.IsTrue(expected.SequenceEqual(actual), "The expected list of commodity prices did not match the actual list of commodity prices");
        }
    }
}
