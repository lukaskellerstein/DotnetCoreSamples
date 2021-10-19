using System;

namespace App
{


    static class MyLinearSearch
    {

        public static void Run()
        {
            // ----------------------------------
            // ----------------------------------
            // LINEAR SEARCH 
            //
            // Time complexity: O(n)
            //
            // Unsorted Array/List
            //
            // https://www.geeksforgeeks.org/linear-search/
            // ----------------------------------
            // ----------------------------------
            int searchValue = 8;
            int[] arr = {
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
            };


            // FOR
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchValue) System.Console.WriteLine("Value found");
            }

            // FOREACH
            foreach (var item in arr)
            {
                if (item == searchValue) System.Console.WriteLine("Value found");
            }

        }
    }
}