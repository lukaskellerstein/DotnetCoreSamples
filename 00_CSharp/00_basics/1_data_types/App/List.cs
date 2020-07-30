using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{

    static class MyList
    {

        // ------------------------------------------------
        // LIST - has dynamic length
        // ------------------------------------------------
        public static void Run()
        {

            // declaration
            List<int> arr0 = new List<int>();
            arr0.Add(10);
            arr0.Add(11);
            arr0.Add(12);
            arr0.Add(13);

            // declaration with initialization
            List<int> arr1 = new List<int> { 1, 2, 3, 4, 5 };



            // ------------------------------------------------
            // MAP, REDUCE 
            // ------------------------------------------------
            // MAP (kind of)
            arr1.ForEach(x =>
            {
                x = x + 1;
                System.Console.WriteLine(x);
            });

            // FILTER
            arr1.Where(x => x > 5).ToList().ForEach(x => System.Console.WriteLine(x));


            // ------------------------------------------------
            // LINQ 
            // ------------------------------------------------
            // viz Intermediate > LINQ

        }
    }



}