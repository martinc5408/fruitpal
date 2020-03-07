using fruitpal.Model;
using fruitpal.Constant;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace fruitpal.DataAccess
{
    public class CountryCommodityData : IFlatFileData<CountryCommodity>
    {
        public List<CountryCommodity> GetDataMatchingSpecifiedFilter(string filter)
        {
            return JsonConvert.DeserializeObject<List<CountryCommodity>>(File.ReadAllText(Environment.CurrentDirectory + Constants.COMMODITIES_PATH));
        }
    }
}
