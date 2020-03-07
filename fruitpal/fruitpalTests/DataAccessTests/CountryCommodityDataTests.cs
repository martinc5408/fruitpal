using fruitpal.Constant;
using fruitpal.DataAccess;
using fruitpal.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fruitpalTests.DataAccessTests
{
    [TestClass]
    public class CountryCommodityDataTests
    {
        private CountryCommodityData countryCommodityData;
        private Mock<IFileReader> mockReader;
        private string data;

        [TestInitialize]
        public void SetUp()
        {
            data = @"[
                        {
                            'COUNTRY': 'MX',
                            'COMMODITY': 'mango',
                            'FIXED_OVERHEAD': '32.00',
                            'VARIABLE_OVERHEAD': '1.24'
                        },
                        {
                            'COUNTRY': 'BR',
                            'COMMODITY': 'mango',
                            'FIXED_OVERHEAD': '20.00',
                            'VARIABLE_OVERHEAD': '1.42'
                        }
                    ]";
            mockReader = new Mock<IFileReader>();
            mockReader.Setup(read => read.ReadFile(Environment.CurrentDirectory + Constants.COMMODITIES_PATH)).Returns(data);
            countryCommodityData = new CountryCommodityData(mockReader.Object);
        }

        [TestMethod]
        public void GetDataMatchingSpecifiedFilter_ValidInput_ReturnResults()
        {
            string filter = "mango";

            List<CountryCommodity> expected = new List<CountryCommodity>
            {
                new CountryCommodity
                {
                    Country = "MX",
                    Commodity = "mango",
                    FixedOverhead = 32.00,
                    VariableOverhead = 1.24
                },
                new CountryCommodity
                {
                    Country = "BR",
                    Commodity = "mango",
                    FixedOverhead = 20.00,
                    VariableOverhead = 1.42
                }
            };

            List<CountryCommodity> actual = countryCommodityData.GetDataMatchingSpecifiedFilter(filter);

            Assert.IsTrue(expected.SequenceEqual(actual), "The expected list of country commodity data did not match the actual list of country commodity data");
        }
    }
}
