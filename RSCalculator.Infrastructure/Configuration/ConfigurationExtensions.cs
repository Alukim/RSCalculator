using System;
using System.Configuration;
using System.IO.Ports;

namespace RSCalculator.Infrastructure.Configuration
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureSerialPortSettings()
        {
            SerialPortConfiguration.Port = ConfigurationManager.AppSettings["Port"];
            SerialPortConfiguration.DataBit = int.Parse(ConfigurationManager.AppSettings["DataBit"]);
            SerialPortConfiguration.Parity = (Parity) Enum.Parse(typeof(Parity), ConfigurationManager.AppSettings["Parity"]);
            SerialPortConfiguration.Speed = int.Parse(ConfigurationManager.AppSettings["Speed"]);
            SerialPortConfiguration.StopBit = (StopBits) Enum.Parse(typeof(StopBits), ConfigurationManager.AppSettings["StopBit"]);
        }

        public static SerialPort ConfigureSerialPort()
        {
            var serialPort = new SerialPort(
                SerialPortConfiguration.Port,
                SerialPortConfiguration.Speed,
                SerialPortConfiguration.Parity,
                SerialPortConfiguration.DataBit,
                SerialPortConfiguration.StopBit);

            return serialPort;
        }
    }
}
