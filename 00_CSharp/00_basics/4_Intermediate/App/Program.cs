using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delegates
            MyDelegate.Run();

            // Events
            MyEvents.Run();


            Console.WriteLine("Press Enter to end the program.");
            Console.ReadLine();
        }
    }
}
