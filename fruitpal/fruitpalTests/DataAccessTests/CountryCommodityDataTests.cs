using fruitpal.DataAccess;
using fruitpal.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace fruitpalTests.DataAccessTests
{
    [TestClass]
    public class CountryCommodityDataTests
    {
        private CountryCommodityData countryCommodityData;

        [TestInitialize]
        public void SetUp()
        {
            countryCommodityData = new CountryCommodityData();
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
                    FixedOverhead = "32.00",
                    VariableOverhead = "1.24"
                },
                new CountryCommodity
                {
                    Country = "BR",
                    Commodity = "mango",
                    FixedOverhead = "20.00",
                    VariableOverhead = "1.42"
                }
            };

            List<CountryCommodity> actual = countryCommodityData.GetDataMatchingSpecifiedFilter(filter);

            Assert.IsTrue(expected.SequenceEqual(actual), "The expected list of country commodity data did not match the actual list of country commodity data");
        }
    }
}
