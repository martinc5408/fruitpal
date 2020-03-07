namespace fruitpal.Services
{
    public interface ICalculatorService<T, K>
    {
        public K Calculate(T operand);
    }
}
