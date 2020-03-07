namespace fruitpal.Logic
{
    public interface ICommodityLogic<T, K, U>
    {
        /// <summary>
        /// Implement interface to orchestrate business logic 
        /// for commodity retrieval of various types. 
        /// Accepts generic price, quantity types and 
        /// generic return type for extensibility. 
        /// </summary>
        /// <param name="commodity"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public U GetCommodityPrices(string commodity, T price, K quantity);
    }
}
