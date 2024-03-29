using System;

namespace App
{
    static class MyJumpSearch
    {
        public static void Run()
        {
            // ----------------------------------
            // ----------------------------------
            // INTERPOLATION SEARCH 
            //
            // Time complexity: O(log log n)
            //
            // SORTED Array/List !!!!
            //
            // https://www.geeksforgeeks.org/interpolation-search/
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
            int result = interpolationSearch(arr, searchValue);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                + result);

        }

        // If x is present in  
        // arr[0..n-1], then  
        // returns index of it,  
        // else returns -1. 
        static int interpolationSearch(int[] arr, int x)
        {
            // Find indexes of 
            // two corners 
            int lo = 0, hi = (arr.Length - 1);

            // Since array is sorted,  
            // an element present in 
            // array must be in range 
            // defined by corner 
            while (lo <= hi &&
                    x >= arr[lo] &&
                    x <= arr[hi])
            {
                if (lo == hi)
                {
                    if (arr[lo] == x) return lo;
                    return -1;
                }

                // Probing the position  
                // with keeping uniform  
                // distribution in mind. 
                int pos = lo + (((hi - lo) /
                                 (arr[hi] - arr[lo])) *
                                       (x - arr[lo]));

                // Condition of  
                // target found 
                if (arr[pos] == x)
                    return pos;

                // If x is larger, x 
                // is in upper part 
                if (arr[pos] < x)
                    lo = pos + 1;

                // If x is smaller, x  
                // is in the lower part 
                else
                    hi = pos - 1;
            }
            return -1;
        }
    }
}