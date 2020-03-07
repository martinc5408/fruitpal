using fruitpal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.DataAccess
{
    public class CountryCommodityData : IFlatFileData<CountryCommodity>
    {
        public List<CountryCommodity> GetDataMatchingSpecifiedFilter(string filter)
        {
            return new List<CountryCommodity>
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
        }
    }
}
