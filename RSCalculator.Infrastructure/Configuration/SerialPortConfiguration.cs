using System.IO.Ports;

namespace RSCalculator.Infrastructure.Configuration
{
    public static class SerialPortConfiguration
    {
        public static int Speed { get; set; }
        public static string Port { get; set; }
        public static int DataBit { get; set; }
        public static Parity Parity { get; set; }
        public static StopBits StopBit { get; set; }
    }
}
