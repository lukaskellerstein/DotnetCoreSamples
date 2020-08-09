using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            int var1 = 5;

            // -------------------------------------------------
            // IF ELSE
            // -------------------------------------------------
            if (var1 < 0)
            {
                Console.WriteLine("Less than zero");
            }
            else if (var1 >= 0 && var1 < 5)
            {
                Console.WriteLine("Bigger than zero, less than five");
            }
            else
            {
                Console.WriteLine("Bigger than five");
            }

            // IF ELSE - TERNARY
            var res1 = (var1 < 0) ? "Less than zero" : "Bigger than zero";

            // -------------------------------------------------
            // SWITCH 
            // -------------------------------------------------
            switch (var1)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
            }


            // -------------------------------------------------
            //FOR
            // -------------------------------------------------
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // -------------------------------------------------
            // FOR EARCH
            // -------------------------------------------------
            int[] arr1 = { 1, 2, 3, 4, 5 };
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            // -------------------------------------------------
            // WHILE
            // -------------------------------------------------
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }


            // -------------------------------------------------
            // DO WHILE 
            // -------------------------------------------------
            int nn = 0;
            do
            {
                Console.WriteLine(nn);
                nn++;
            } while (nn < 5);

            // -------------------------------------------------
            // JUMP
            // -------------------------------------------------

            while (true)
            {
                Console.WriteLine("This prints once.");
                // A `break` statement immediately terminates the loop that contains it.
                break;
            }

            for (int i = 1; i <= 10; i++)
            {
                // This prints every number from 1 to 10 except for 7.
                if (i == 7)
                {
                    // A `continue` statement skips the rest of the loop and starts another iteration from the start.
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
