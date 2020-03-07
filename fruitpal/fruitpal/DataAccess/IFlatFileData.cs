using System.Collections.Generic;

namespace fruitpal.DataAccess
{
    public interface IFlatFileData<T>
    {
        public List<T> GetDataMatchingSpecifiedFilter(string filter);
    }
}
