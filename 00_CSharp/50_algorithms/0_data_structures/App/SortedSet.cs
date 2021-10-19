using System.Collections.Generic;

namespace App
{

    public static class MySortedSet
    {
        public static void Run()
        {

            // ----------------------------------
            // ----------------------------------
            // SORTED SET 
            // keeps values inside sorted by keys
            //
            //  is a Red-black tree
            // ----------------------------------
            // ----------------------------------
            var col1 = new SortedSet<string>(new string[] { "zzz", "xxx", "yyy" });

            // Access by index 
            // not possible

            // Access by key 
            // not possible

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add - O(log n) always
            // BUT if inner array needs to be bigger -> O(n)
            col1.Add("000");

            // Insert - O(log n) always
            // not possible

            // Remove - O(log n) always
            col1.Remove("000");

            // Update - O(log n) always
            // not possible




            // ----------------------------------
            // SORT
            // ----------------------------------
            // it is sorted by default
            // prove
            foreach (var item in col1)
            {
                System.Console.WriteLine(item);
            }



            // ----------------------------------
            // SEARCH
            // ----------------------------------

            //1 - For-each - Brute-force - O(n)
            var result = "";
            foreach (var item in col1)
            {
                if (item == "ccc")
                {
                    result = item;
                }
            };

            //2 - Contains - O(log n) always
            var result2 = col1.Contains("ccc");

        }
    }
}