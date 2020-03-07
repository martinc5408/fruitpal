namespace fruitpal.Services
{
    public interface ICalculatorService<T, K>
    {
        /// <summary>
        /// Implement interface to calculate for generic type operand. 
        /// Returns generic type for extensibility.
        /// </summary>
        /// <param name="operand"></param>
        /// <returns></returns>
        public K Calculate(T operand);
    }
}
