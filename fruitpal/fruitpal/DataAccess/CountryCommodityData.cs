using fruitpal.Constant;
using fruitpal.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fruitpal.DataAccess
{
    public class CountryCommodityData : IFlatFileData<CountryCommodity>
    {
        private IFileReader FileReader;

        public CountryCommodityData(IFileReader fileReader)
        {
            FileReader = fileReader;
        }

        /// <summary>
        /// Retrieves data from stored commodities flat file. 
        /// Parses json and returns filtered List of CountryCommodity.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<CountryCommodity> GetDataMatchingSpecifiedFilter(string filter)
        {
            return JsonConvert.DeserializeObject<List<CountryCommodityRecord>>(
                    FileReader.ReadFile(Environment.CurrentDirectory + Constants.COMMODITIES_PATH))
                .Where(countryCommodity => countryCommodity.Commodity.Equals(filter))
                .Select(countryCommodityRecord => new CountryCommodity()
                    {
                        Country = countryCommodityRecord.Country,
                        Commodity = countryCommodityRecord.Commodity,
                        FixedOverhead = double.Parse(countryCommodityRecord.FixedOverhead),
                        VariableOverhead = double.Parse(countryCommodityRecord.VariableOverhead)
                    })
                .ToList();
        }
    }
}
