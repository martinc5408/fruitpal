namespace fruitpal.Logic
{
    public interface ICommodityLogic<T, K, U>
    {
        public U GetCommodityPrices(string commodity, T price, K quantity);
    }
}
