namespace RSCalculator.Infrastructure.SerialPorts.Abstracts
{
    public interface IController
    {
        double Execute(string action, params double[] parameters);
    }
}
