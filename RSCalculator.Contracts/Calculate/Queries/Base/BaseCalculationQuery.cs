using Infrastructure.Messages.Abstracts;

namespace RSCalculator.Contracts.Calculate.Queries.Base
{
    public abstract class BaseCalculationQuery : IQuery<double>
    {
        public BaseCalculationQuery(double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public double FirstNumber { get; private set; }
        public double SecondNumber { get; private set; }
    }
}
