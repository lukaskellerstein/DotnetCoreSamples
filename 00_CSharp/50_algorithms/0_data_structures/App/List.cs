using System.Collections.Generic;

namespace App
{


    public static class MyList
    {
        public static void Run()
        {
            // ----------------------------------
            // ----------------------------------
            // LIST 
            // ----------------------------------
            // ----------------------------------
            var col1 = new List<string>() { "aaa", "bbb", "ccc" };

            System.Console.WriteLine(col1.Capacity);
            var col2 = new List<string>();
            System.Console.WriteLine(col2.Capacity);

            // Access by index - O(1)
            var someItem = col1[2];

            // Access by key 
            // not possible

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add (to the end) - O(1)
            // BUT if inner array needs to be bigger -> O(n)
            col1.Add("ddd");

            // Insert (at index) - O(n)
            col1.Insert(0, "0000");

            // Remove - O(n)
            col1.Remove("aaa");
            col1.RemoveAt(0);

            // Update - O(1)
            col1[1] = "changed";



            // ----------------------------------
            // SORT
            // ----------------------------------

            // This method uses Array.Sort internally, which uses the QuickSort algorithm. 
            // On average, this method is an O(n log n) operation, where n is Count; in the worst case it is an O(n ^ 2) operation.
            col1.Sort();


            // ----------------------------------
            // SEARCH
            // ----------------------------------

            //1 - For-each - Brute-force - O(n)
            var result = "";
            foreach (var item in col1)
            {
                if (item == "ddd")
                {
                    result = item;
                }
            };

            //2 - Exist - Linear Search - O(n)
            var result1 = col1.Exists(x => x == "ddd");

            //3 - Find - Linear Search - O(n)
            var result2 = col1.Find(x => x == "ddd");

        }
    }
}