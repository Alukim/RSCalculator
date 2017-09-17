using RSCalculator.Contracts.Calculate.Queries.Base;

namespace RSCalculator.Contracts.Calculate.Queries
{
    public class AddQuery : BaseCalculationQuery
    {
        public AddQuery(double firstNumber, double secondNumber) 
            : base(firstNumber, secondNumber) {}
    }
}
