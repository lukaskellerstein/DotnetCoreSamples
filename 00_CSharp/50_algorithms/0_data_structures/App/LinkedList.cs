using System;
using System.Text;
using System.Collections.Generic;

namespace App
{


    static class MyLinkedList
    {

        public static void Run()
        {

            // ----------------------------------
            // ----------------------------------
            // LINKED-LIST (Doubly-linked) 
            // ----------------------------------
            // ----------------------------------
            var col1 = new LinkedList<string>(new string[] { "aaa", "bbb", "ccc" });


            // Access by index 
            // not possible

            // Access by key 
            // not possible

            // Access by nodes
            LinkedListNode<string> mark1 = col1.First;
            LinkedListNode<string> mark2 = mark1.Previous;
            LinkedListNode<string> mark3 = mark1.Next;

            // ----------------------------------
            // CRUD OPERATIONS
            // ----------------------------------

            // Add - O(1)
            col1.AddFirst("000");
            col1.AddLast("ddd");

            // Insert - O(1)
            col1.AddBefore(mark1, "before");
            col1.AddAfter(mark1, "after");

            // Remove 
            col1.Remove("bbb"); // O(n)
            col1.Remove(mark1); // O(1)
            col1.RemoveFirst(); // O(1)
            col1.RemoveLast(); // O(1)

            // Update - O(1)
            col1.Find("ccc").Value = "changed";




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

            //2 - Find - Linear Search - O(n)
            var result2 = col1.Find("ddd");


        }

    }
}