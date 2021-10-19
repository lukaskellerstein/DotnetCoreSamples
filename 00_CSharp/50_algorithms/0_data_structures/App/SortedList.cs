using System;
using System.Collections.Generic;

namespace App
{


    public static class MySortedList
    {
        public static void Run()
        {
            // ----------------------------------
            // ----------------------------------
            // SORTED LIST
            // keeps values inside sorted by keys
            // inside uses two arrays (for keys and for values) 
            //
            // uses less memory than SortedDictionary<TKey,TValue>
            // supports efficient indexed retrieval of keys and values
            // ----------------------------------
            // ----------------------------------
            var col1 = new SortedList<string, string>();
            col1.Add("zzz", "Admin");
            col1.Add("xxx", "Adam Hoff");
            col1.Add("yyy", "li lian");
            col1.Add("www", "lorem ipsum");
            col1.Add("vvv", "description");

            // Access by index 
            var someKey = col1.Keys[1];
            var someValue = col1.Values[1];

            // Access by key - O(log n) 
            var someItem = col1["xxx"];

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add - O(n)
            col1.Add("bbb", "Petr Shell");
            col1.Add("ccc", "User");

            // Insert
            // not possible

            // Remove - O(n)
            col1.Remove("xxx");

            // Update - O(log n)
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
            foreach (var item in col1)
            {
                if (item.Key == "name")
                {
                    result = item.Value;
                }
            };

            //2 - Contains 
            var result2 = col1.ContainsKey("ccc"); // O(log n)
            var result3 = col1.ContainsValue("Admin"); // O(n)


        }
    }
}