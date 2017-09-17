using System;
using System.Diagnostics;

namespace RSCalculator.Infrastructure.Console
{
    public static class ConsoleExtensions
    {
        public static void WriteError(string message)
            => WriteMessage(MessageType.Error, message, ConsoleColor.Red);

        public static void WriteSuccess(string message)
            => WriteMessage(MessageType.Success, message, ConsoleColor.Green);

        public static void WriteInfo(string message)
            => WriteMessage(MessageType.Info, message, ConsoleColor.Blue);

        private static void WriteMessage(MessageType type, string message, ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine($"[{type.ToString()}] : {message}");
            Debug.WriteLine($"[{type.ToString()}] : {message}");
        }
    }
}
