using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Model
{
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
