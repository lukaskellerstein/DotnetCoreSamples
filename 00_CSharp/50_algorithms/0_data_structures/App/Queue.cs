using System.Collections.Generic;

namespace App
{

    public static class MyQueue
    {
        public static void Run()
        {

            // ----------------------------------
            // ----------------------------------
            // QUEUE - FIFO
            // based on Linked-list
            // ----------------------------------
            // ----------------------------------
            var col1 = new Queue<string>(new string[] { "aaa", "bbb", "ccc" });

            // Access by index 
            // not possible

            // Access by key 
            // not possible

            // Access first item - O(1)
            var aaa = col1.Peek();

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add - O(1)
            // BUT if inner array needs to be bigger -> O(n)
            col1.Enqueue("000");

            // Insert - O(1)
            // not possible

            // Remove - O(1)
            var bbb = col1.Dequeue();

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
                if (item == "ddd")
                {
                    result = item;
                }
            };

            //2 - Contains - O(n)
            var result2 = col1.Contains("ddd");

        }
    }
}