using Newtonsoft.Json;

namespace fruitpal.Model
{
    /// <summary>
    /// Model for raw Country based Commodity data.
    /// Contains string cost types as per 3rd-Party data 
    /// constraint; to be converted to CountryCommodity.
    /// </summary>
    public class CountryCommodityRecord
    {
        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("COMMODITY")]
        public string Commodity { get; set; }

        [JsonProperty("FIXED_OVERHEAD")]
        public string FixedOverhead { get; set; }

        [JsonProperty("VARIABLE_OVERHEAD")]
        public string VariableOverhead { get; set; }
    }
}
