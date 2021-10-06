using System;
using CentralSecuritySystem.Ressources;

namespace CentralSecuritySystem
{
    public class Presenter
    {
        public static void PrintMessage(string message, LoggingLevelEnum logLevel)
        {
            switch (logLevel)
            {
                case LoggingLevelEnum.Danger:
                    Print(message, ConsoleColor.Red);
                    break;
                
                case LoggingLevelEnum.Warning:
                    Print(message, ConsoleColor.Yellow);
                    break;
                
                case LoggingLevelEnum.Info:
                    Print(message, ConsoleColor.DarkCyan);
                    break;
                
                case LoggingLevelEnum.Debug:
                    Print(message, ConsoleColor.DarkGray);
                    break;
                
                default:
                    Print(message, ConsoleColor.White);
                    break;
            }
        }

        private static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}