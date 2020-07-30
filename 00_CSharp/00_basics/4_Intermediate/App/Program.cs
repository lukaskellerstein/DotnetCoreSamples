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


            // LINQ
            MyLINQ.Run();


            // Methods
            MyMethods.Run();


            Console.WriteLine("Press Enter to end the program.");
            Console.ReadLine();
        }
    }
}
