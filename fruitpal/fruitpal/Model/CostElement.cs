namespace fruitpal.Model
{
    /// <summary>
    /// Model for cost calculation.
    /// </summary>
    public class CostElement
    {
        public int Price { get; set; }
        public int Quantity { get; set; }
        public CountryCommodity Commodity { get; set; }
    }
}
