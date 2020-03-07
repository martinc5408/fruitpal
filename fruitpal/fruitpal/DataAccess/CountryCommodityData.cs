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
            throw new NotImplementedException();
        }
    }
}
