using System;
using System.Collections;

namespace App
{


    public static class MyArray
    {
        public static void Run()
        {
            // ----------------------------------
            // ----------------------------------
            // ARRAY 
            // ----------------------------------
            // ----------------------------------
            var arr1 = new string[] { "aaa", "bbb", "ccc" };


            // Access by index - O(1)
            var someItem = arr1[2];

            // Access by key 
            // not possible

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add (to the end)
            // not possible

            // Insert (at index)
            // not possible

            // Remove
            // not possible

            // Update - O(1)
            arr1[2] = "eee";



            // ----------------------------------
            // SORT
            // ----------------------------------

            // This method uses Array.Sort, which uses the QuickSort algorithm. 
            // On average, this method is an O(n log n) operation, 
            // where n is Count; 
            // in the worst case it is an O(n ^ 2) operation.
            Array.Sort(arr1);


            // ----------------------------------
            // SEARCH
            // ----------------------------------

            // Brute-force - O(n)
            //2
            var result = "";
            foreach (var item in arr1)
            {
                if (item == "ddd")
                {
                    result = item;
                }
            };

        }
    }
}