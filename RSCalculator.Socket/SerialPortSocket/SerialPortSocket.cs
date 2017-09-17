using System;
using System.IO.Ports;
using RSCalculator.Contracts.Exceptions;
using RSCalculator.Controllers;
using RSCalculator.Infrastructure.Console;
using RSCalculator.Infrastructure.SerialPorts.Abstracts;

namespace RSCalculator.Socket.SerialPortSocket
{
    public class SerialPortSocket : IDisposable
    {
        private readonly IController controller;
        private readonly SerialPort serialPort;
        private bool _continue;
        private static StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

        public SerialPortSocket(SerialPort serialPort)
        {
            this.controller = new CalculateController();
            this._continue = true;
            this.serialPort = serialPort;
        }

        public void Dispose()
        {
            serialPort.Close();
        }

        public void Run()
        {
            serialPort.Open();
            ConsoleExtensions.WriteInfo("Open serialPort");
            ConsoleExtensions.WriteInfo("Start received data");
            ReceivedData();
        }

        private void ReceivedData()
        {
            while (_continue)
            {
                try
                {
                    var message = serialPort.ReadLine();
                    ConsoleExtensions.WriteInfo($"Received message: {message}");

                    var splittedMessage = message.Split(' ');

                    if (stringComparer.Equals("hlp", splittedMessage[0]))
                    {
                        serialPort.WriteLine(GetHelp());
                    }
                    else
                    {
                        if (splittedMessage.Length != 3)
                            throw new NotSupportedOperation(splittedMessage[0]);

                        var first = double.Parse(splittedMessage[1]);
                        var second = double.Parse(splittedMessage[2]);

                        controller.Execute(splittedMessage[0], first, second);
                    }
                }
                catch (NotSupportedOperation)
                {
                    ConsoleExtensions.WriteError("Not supported operation. Type HLP to get help");
                    serialPort.WriteLine("Not supported operation. Type HLP to get help");
                }
                catch (Exception ex)
                {
                    ConsoleExtensions.WriteError($"Error: {ex.Message}");
                    serialPort.WriteLine($"Error: {ex.Message}");
                    _continue = false;
                }
            }
        }

        private string GetHelp()
        {
            return "";
        }
    }
}
