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
            var totalVariable = operand.VariableOverhead + operand.Price;

            return AsCostResult(
                (totalVariable * operand.Quantity) + operand.FixedOverhead,
                totalVariable,
                operand.FixedOverhead,
                operand.Quantity);

        }

        private CostResult AsCostResult(double grandTotal, double totalVariable, double fixedOverhead, int quantity)
        {
            return new CostResult
            {
                GrandTotal = grandTotal,
                TotalVariable = totalVariable,
                Fixed = fixedOverhead,
                Quantity = quantity
            };
        }
    }
}
