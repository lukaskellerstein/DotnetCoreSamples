using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // without lambda
            Logger.WriteMessage += LoggingMethods.LogToConsole;

            // with lambda
            Logger.WriteMessage += (string message) => Console.Error.WriteLine(message);

            Logger.LogMessage("SOME ERROR HAPPENED");
        }
    }
}
