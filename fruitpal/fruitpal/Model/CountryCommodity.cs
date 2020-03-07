using System;

namespace fruitpal.Model
{
    /// <summary>
    /// Model for Country based Commodity data
    /// with double type cost values.
    /// </summary>
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
