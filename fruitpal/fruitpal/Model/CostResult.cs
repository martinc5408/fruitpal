using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Model
{
    public class CostResult
    {
        public string Country { get; set; }
        public double GrandTotal { get; set; }
        public double TotalVariable { get; set; }
        public double Fixed { get; set; }
        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CostResult result &&
                   Country == result.Country &&
                   GrandTotal == result.GrandTotal &&
                   TotalVariable == result.TotalVariable &&
                   Fixed == result.Fixed &&
                   Quantity == result.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Country, GrandTotal, TotalVariable, Fixed, Quantity);
        }
    }
}
