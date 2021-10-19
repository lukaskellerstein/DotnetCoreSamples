using System.Collections.Generic;

namespace App
{

    public static class MyHashSet
    {
        public static void Run()
        {

            // ----------------------------------
            // ----------------------------------
            // HASHSET - Unique values !!!!
            // ----------------------------------
            // ----------------------------------
            var col1 = new HashSet<string>(new string[] { "aaa", "bbb", "ccc" });

            // Access by index 
            // not possible

            // Access by key 
            // not possible

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add - O(1)
            // BUT if inner array needs to be bigger -> O(n)
            col1.Add("000");

            // Insert - O(1)
            // not possible

            // Remove - O(1)
            col1.Remove("000");

            // Update - O(1)
            // not possible




            // ----------------------------------
            // SORT
            // ----------------------------------
            // Not possible ???


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

            //2 - Contains - O(1)
            var result2 = col1.Contains("ccc");

        }
    }
}