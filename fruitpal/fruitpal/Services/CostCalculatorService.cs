using fruitpal.Model;
using System;

namespace fruitpal.Services
{
    public class CostCalculatorService : ICalculatorService<CostElement, CostResult>
    {
        /// <summary>
        /// Performs calculation for CostElement operand parameter.
        /// Return CostResult object with calculation results.
        /// </summary>
        /// <param name="operand"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Creates CostResult object from calculation-drive parameters.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="grandTotal"></param>
        /// <param name="totalVariable"></param>
        /// <param name="fixedOverhead"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
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
