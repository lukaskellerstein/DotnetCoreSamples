using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var mycp1 = new MyComponent();

            // -----------------------------------------
            // ANONYMOUS Lambda
            // -----------------------------------------

            // Subscribe to the event
            mycp1.UserSelected += (sender, eventArgs) =>
            {
                Console.WriteLine("Log Event - UserSelected in MyEvents class");
                Console.WriteLine(eventArgs);
            };

            // ANONYMOUS - CANNOT UNSUBSCRIBE !!!!

            // -----------------------------------------
            // NON-ANONYMOUS Lambda
            // -----------------------------------------

            // Declaration
            EventHandler<string> handler = (sender, eventArgs) =>
            {
                Console.WriteLine("Log Event 2 - UserSelected in MyEvents class");
                Console.WriteLine(eventArgs);
            };

            // Subscribe to the event
            mycp1.UserSelected += handler;

            // Usubscribe to the event
            mycp1.UserSelected -= handler;

        }
    }
}
