using System;

namespace App
{


    static class MyJumpSearch
    {

        public static void Run()
        {
            // ----------------------------------
            // ----------------------------------
            // JUMP SEARCH 
            //
            // Time complexity: O(√n)
            //
            // SORTED Array/List !!!!
            //
            // https://www.geeksforgeeks.org/jump-search/
            // ----------------------------------
            // ----------------------------------
            int searchValue = 8;
            int[] arr = {
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
                new Random().Next(1,10),
            };

            // 1 - SORT ARRAY
            Array.Sort(arr);

            // 2 - SEARCH
            int result = jumpSearch(arr, searchValue);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                + result);

        }

        public static int jumpSearch(int[] arr, int x)
        {
            int n = arr.Length;

            // Finding block size to be jumped 
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Finding the block where element is 
            // present (if it is present) 
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            // Doing a linear search for x in block 
            // beginning with prev. 
            while (arr[prev] < x)
            {
                prev++;

                // If we reached next block or end of 
                // array, element is not present. 
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // If element is found 
            if (arr[prev] == x)
                return prev;

            return -1;
        }
    }
}