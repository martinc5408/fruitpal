using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Model
{
    public class CountryCommodity
    {
        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("COMMODITY")]
        public string Commodity { get; set; }

        [JsonProperty("FIXED_OVERHEAD")]
        public string FixedOverhead { get; set; }

        [JsonProperty("VARIABLE_OVERHEAD")]
        public string VariableOverhead { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CountryCommodity commodity &&
                   Country == commodity.Country &&
                   Commodity == commodity.Commodity &&
                   FixedOverhead == commodity.FixedOverhead &&
                   VariableOverhead == commodity.VariableOverhead;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Country, Commodity, FixedOverhead, VariableOverhead);
        }
    }
}
