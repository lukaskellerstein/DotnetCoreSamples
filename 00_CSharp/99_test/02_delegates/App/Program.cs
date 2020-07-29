using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            // Basic Logger
            Logger.WriteMessage += (string message) => Console.Error.WriteLine(message);

            Logger.LogMessage(Severity.Error, "MyComponent", "SOME ERROR HAPPENED");


            // File Logger - is using Basic Logger inside
            var fileLog = new FileLogger("log.txt");

            Logger.LogMessage(Severity.Error, "MyComponent", "Some message for file log");


        }
    }
}
