using System;
using System.Collections.Generic;

namespace App
{

    public static class MyDictionary
    {
        public static void Run()
        {

            // ----------------------------------
            // ----------------------------------
            // DICTIONARY - as Map (in Golang) or Object (in JS)
            // Unique key values !!!!
            // 
            // The Dictionary collection is faster than Hashtable because there is no boxing and unboxing.
            // ----------------------------------
            // ----------------------------------
            var col1 = new Dictionary<string, string>();
            col1.Add("name", "Adam Hoff");
            col1.Add("role", "Admin");

            // Access by index 
            // not possible

            // Access by key - O(1)
            var bbb = col1["name"];

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add - O(1)
            // BUT if inner array needs to be bigger -> O(n)
            try
            {
                col1.Add("name", "Petr Shell");
                col1.Add("role", "User");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // Insert
            // not possible

            // Remove - O(1)
            col1.Remove("000");

            // Update - O(1)
            col1["role"] = "changed";




            // ----------------------------------
            // SORT
            // ----------------------------------
            // Not possible ???


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
            var result2 = col1.ContainsKey("ccc"); // O(1)
            var result3 = col1.ContainsValue("Admin"); // O(n)

        }
    }
}