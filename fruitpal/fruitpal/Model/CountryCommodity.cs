using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Model
{
    public class CountryCommodity
    {
        public string Country { get; set; }
        public string Commodity { get; set; }
        public double FixedOverhead { get; set; }
        public double VariableOverhead { get; set; }

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
