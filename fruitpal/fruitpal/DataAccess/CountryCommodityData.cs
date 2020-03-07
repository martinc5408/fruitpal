using fruitpal.Model;
using fruitpal.Constant;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Linq;

namespace fruitpal.DataAccess
{
    public class CountryCommodityData : IFlatFileData<CountryCommodity>
    {
        public List<CountryCommodity> GetDataMatchingSpecifiedFilter(string filter)
        {
            return JsonConvert.DeserializeObject<List<CountryCommodityRecord>>(
                    File.ReadAllText(Environment.CurrentDirectory + Constants.COMMODITIES_PATH))
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
