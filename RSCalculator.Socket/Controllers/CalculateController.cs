using RSCalculator.Contracts.Abstracts;
using RSCalculator.Contracts.Calculate.Queries;
using RSCalculator.Contracts.Exceptions;
using RSCalculator.Handlers.Calculate;
using RSCalculator.Infrastructure.SerialPorts.Abstracts;

namespace RSCalculator.Controllers
{
    public class CalculateController : IController
    {
        private readonly ICalculateHandler handler;

        public CalculateController()
        {
            this.handler = new CalculateHandler();
        }

        public double Execute(string action, params double[] parameters)
        {
            switch(action.ToLowerInvariant())
            {
                case "add":
                    return Add(parameters[0], parameters[1]);
                case "substract":
                    return Substract(parameters[0], parameters[1]);
                case "multiply":
                    return Multiply(parameters[0], parameters[1]);
                case "divide":
                    return Divide(parameters[0], parameters[1]);
                default:
                    throw new NotSupportedOperation(action);
            }
        }

        private double Add(double first, double second)
            => handler.Handle(new AddQuery(first, second));

        private double Substract(double first, double second)
            => handler.Handle(new SubtractQuery(first, second));

        private double Multiply(double first, double second)
            => handler.Handle(new MultiplyQuery(first, second));

        private double Divide(double first, double second)
            => handler.Handle(new DivideQuery(first, second));
    }
}
