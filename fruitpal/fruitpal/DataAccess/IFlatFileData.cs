using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.DataAccess
{
    public interface IFlatFileData<T>
    {
        public List<T> GetDataMatchingSpecifiedFilter(string filter);
    }
}
