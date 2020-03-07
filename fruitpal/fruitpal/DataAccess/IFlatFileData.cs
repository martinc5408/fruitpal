using System.Collections.Generic;

namespace fruitpal.DataAccess
{
    public interface IFlatFileData<T>
    {
        /// <summary>
        /// Implement interface to retrieve List of Generic Type
        /// filtered by parameter value.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<T> GetDataMatchingSpecifiedFilter(string filter);
    }
}
