namespace fruitpal.Constant
{
    /// <summary>
    /// Constants class
    /// </summary>
    public static class Constants
    {
        //Resource Locations
        public const string COMMODITIES_PATH = @"..\..\..\..\Resources\commodities.json";

        //Formats
        public const string DECIMAL_FORMAT = "{0:0.00}";

        //Messages
        public const string VALID_NO_PARAMETERS = "Please provide the correct number of parameters.\nUsage: fruitpal <commodity> <price> <quantity>";
        public const string VALID_INT_PARAMETERS = "Please enter non-negative integer values for price and quantity.\nUsage: fruitpal <commodity> <price> quantity>";
    }
}
