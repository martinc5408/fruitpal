using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Services
{
    public interface ICalculatorService<T, K>
    {
        public K Calculate(T operand);
    }
}
