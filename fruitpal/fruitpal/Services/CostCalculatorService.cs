using fruitpal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Services
{
    public class CostCalculatorService : ICalculatorService<CostElement, CostResult>
    {
        public CostResult Calculate(CostElement operand)
        {
            CountryCommodity commodity = operand.Commodity;
            var totalVariable = commodity.VariableOverhead + operand.Price;

            return AsCostResult(
                commodity.Country,
                Math.Round((totalVariable * operand.Quantity) + commodity.FixedOverhead, 2),
                totalVariable,
                commodity.FixedOverhead,
                operand.Quantity);

        }

        private CostResult AsCostResult(string country, double grandTotal, double totalVariable, double fixedOverhead, int quantity)
        {
            return new CostResult
            {
                Country = country,
                GrandTotal = grandTotal,
                TotalVariable = totalVariable,
                Fixed = fixedOverhead,
                Quantity = quantity
            };
        }
    }
}
