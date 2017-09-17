using System;

namespace RSCalculator.Contracts.Exceptions
{
    public class NotSupportedOperation : Exception
    {
        public NotSupportedOperation(string operation)
            : base($"Operation \"{operation}\" is not supported") { }
    }
}
