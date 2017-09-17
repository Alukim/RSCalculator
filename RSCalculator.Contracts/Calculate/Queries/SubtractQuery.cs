using RSCalculator.Contracts.Calculate.Queries.Base;

namespace RSCalculator.Contracts.Calculate.Queries
{
    public class SubtractQuery : BaseCalculationQuery
    {
        public SubtractQuery(double firstNumber, double secondNumber) 
            : base(firstNumber, secondNumber) {}
    }
}
