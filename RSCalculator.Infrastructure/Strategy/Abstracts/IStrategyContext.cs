namespace Infrastructure.Strategy.Abstracts
{
    /// <summary>
    /// Base interface for all strategy contexts
    /// </summary>
    /// <typeparam name="TStrategy">Type of strategy</typeparam>
    public interface IStrategyContext<TStrategy>
        where TStrategy : IStrategy
    {
        TStrategy Strategy { get; }
    }
}
