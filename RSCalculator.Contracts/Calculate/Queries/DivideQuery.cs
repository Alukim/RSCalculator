using RSCalculator.Contracts.Calculate.Queries.Base;

namespace RSCalculator.Contracts.Calculate.Queries
{
    public class DivideQuery : BaseCalculationQuery
    {
        public DivideQuery(double firstNumber, double secondNumber) 
            : base(firstNumber, secondNumber) { }
    }
}
