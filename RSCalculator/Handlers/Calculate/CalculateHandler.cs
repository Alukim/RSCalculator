using RSCalculator.Contracts.Abstracts;
using RSCalculator.Contracts.Calculate.Queries;

namespace RSCalculator.Handlers.Calculate
{
    public class CalculateHandler : ICalculateHandler
    {
        public double Handle(AddQuery query)
            => query.FirstNumber + query.SecondNumber;

        public double Handle(SubtractQuery query)
            => query.FirstNumber - query.SecondNumber;

        public double Handle(MultiplyQuery query)
            => query.FirstNumber * query.SecondNumber;

        public double Handle(DivideQuery query)
            => query.FirstNumber / query.SecondNumber;
    }
}
