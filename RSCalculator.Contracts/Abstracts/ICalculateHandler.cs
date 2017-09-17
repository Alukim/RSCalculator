using RSCalculator.Contracts.Calculate.Queries;
using Infrastructure.Messages.Abstracts;

namespace RSCalculator.Contracts.Abstracts
{
    public interface ICalculateHandler :
        IQueryHandler<AddQuery, double>,
        IQueryHandler<SubtractQuery, double>,
        IQueryHandler<MultiplyQuery, double>,
        IQueryHandler<DivideQuery, double>
    {
    }
}
