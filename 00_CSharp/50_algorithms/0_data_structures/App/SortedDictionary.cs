using System.Collections.Generic;

namespace App
{

    public static class MySortedDictionary
    {
        public static void Run()
        {

            // ----------------------------------
            // ----------------------------------
            // SORTED DICTIONARY 
            // keeps values inside sorted by keys
            //
            //  is a binary search tree
            // ----------------------------------
            // ----------------------------------
            var col1 = new SortedDictionary<string, string>();
            col1.Add("zzz", "Admin");
            col1.Add("xxx", "Adam Hoff");
            col1.Add("yyy", "li lian");
            col1.Add("www", "lorem ipsum");
            col1.Add("vvv", "description");

            // Access by index 
            // not possible

            // Access by key - O(log n) - worst case - O(n)
            var someItem = col1["www"];

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add - O(log n) - worst case - O(n)
            col1.Add("bbb", "Petr Shell");
            col1.Add("ccc", "User");

            // Insert
            // not possible

            // Remove - O(log n) - worst case - O(n)
            col1.Remove("xxx");

            // Update - O(log n) - worst case - O(n)
            col1["ccc"] = "changed";




            // ----------------------------------
            // SORT
            // ----------------------------------
            // it is sorted by default
            // prove
            foreach (var item in col1)
            {
                System.Console.WriteLine($"{item.Key}-{item.Value}");
            }


            // ----------------------------------
            // SEARCH
            // ----------------------------------

            //1 - For-each - Brute-force - O(n)
            var result = "";
            foreach (var kvp in col1)
            {
                if (kvp.Key == "name")
                {
                    result = kvp.Value;
                }
            };

            //2 - Contains 
            var result2 = col1.ContainsKey("ccc"); // O(log n)
            var result3 = col1.ContainsValue("Admin"); // O(n)

        }
    }
}