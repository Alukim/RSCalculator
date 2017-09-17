using System;
using System.Threading;
using RSCalculator.Infrastructure.Configuration;
using RSCalculator.Infrastructure.Console;

namespace RSCalculator.Socket
{
    public class Program
    {
        private static bool _continue = true;
        private static string message = "";
        private static StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        private static SerialPortSocket.SerialPortSocket socket;

        static void Main(string[] args)
        {
            ConfigureApplication();
            var serialPort = ConfigurationExtensions.ConfigureSerialPort();
            socket = new SerialPortSocket.SerialPortSocket(serialPort);
            ConsoleExtensions.WriteSuccess("Application started");
            var thread = new Thread(socket.Run);
            thread.Start();
            Run(thread);
        }

        private static void Run(Thread readThread)
        {
            ConsoleExtensions.WriteInfo("Type QUIT to exit");

            while (_continue)
            {
                message = Console.ReadLine().ToLowerInvariant();

                if (stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
            }

            readThread.Join();
        }

        private static void ConfigureApplication()
        {
            ConfigurationExtensions.ConfigureSerialPortSettings();
            ConsoleExtensions.WriteInfo("Serial port configuration:");
            ConsoleExtensions.WriteInfo($"Parity: {SerialPortConfiguration.Parity}");
            ConsoleExtensions.WriteInfo($"Speed: {SerialPortConfiguration.Speed}");
            ConsoleExtensions.WriteInfo($"DataBit: {SerialPortConfiguration.DataBit}");
            ConsoleExtensions.WriteInfo($"Port: {SerialPortConfiguration.Port}");
            ConsoleExtensions.WriteInfo($"StopBit: {SerialPortConfiguration.StopBit}");
        }
    }
}
