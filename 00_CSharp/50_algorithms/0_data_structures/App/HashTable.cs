using System;
using System.Collections;
using System.Collections.Generic;

namespace App
{

    public static class MyHashTable
    {
        public static void Run()
        {

            // ----------------------------------
            // ----------------------------------
            // HASHTABLE 
            // Unique key values !!!!
            //
            // The Dictionary collection is faster than Hashtable because there is no boxing and unboxing.
            // ----------------------------------
            // ----------------------------------
            var col1 = new Hashtable();
            col1.Add("name", "Adam Hoff");
            col1.Add("role", "Admin");

            // Access by index 
            var aaa = col1[0];

            // Access by key 
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
            col1.Remove("name");

            // Update - O(1)
            col1["name"] = "name is changed";




            // ----------------------------------
            // SORT
            // ----------------------------------
            // Not possible ???


            // ----------------------------------
            // SEARCH
            // ----------------------------------

            //1 - For-each - Brute-force - O(n)
            var result = "";
            foreach (DictionaryEntry item in col1)
            {
                if (item.Key.ToString() == "ccc")
                {
                    result = item.Value.ToString();
                }
            };

            //2 - Contains - O(1)
            var result2 = col1.ContainsKey("ccc");
            var result3 = col1.ContainsValue("Admin");

        }
    }
}