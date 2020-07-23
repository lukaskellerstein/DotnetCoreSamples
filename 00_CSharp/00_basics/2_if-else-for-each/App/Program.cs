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
            switch (va1)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Not interested in this number");
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
            var arr1 = { 1, 2, 3, 4, 5 };
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            // -------------------------------------------------
            // WHILE
            // -------------------------------------------------
            string guess = "";
            Console.WriteLine("What animal am I thinking of?");

            // This loop will keep prompting the user, until they type in "dog".
            while (guess != "dog")
            {
                Console.WriteLine("Make a guess:");
                guess = Console.ReadLine();
            }
            Console.WriteLine("That's right!");


            // -------------------------------------------------
            // DO WHILE 
            // -------------------------------------------------
            do
            {
                DoStuff();
            } while (boolCondition);

            // This do-while is equivalent to the following while loop.

            DoStuff();
            while (boolCondition)
            {
                DoStuff();
            }

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

            static int WeirdReturnOne()
            {
                while (true)
                {
                    // Since `return` exits the method, the loop is also terminated. Control returns to the method's caller.
                    return 1;
                }
            }
        }
    }
}
