using RSCalculator.Contracts.Calculate.Queries.Base;

namespace RSCalculator.Contracts.Calculate.Queries
{
    public class MultiplyQuery : BaseCalculationQuery
    {
        public MultiplyQuery(double firstNumber, double secondNumber) 
            : base(firstNumber, secondNumber) { }
    }
}
