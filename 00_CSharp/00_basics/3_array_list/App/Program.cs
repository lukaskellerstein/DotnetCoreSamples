using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------
            // ARRAY - has fixed length
            // ------------------------------------------------
            Array();


            // ------------------------------------------------
            // LIST - has fixed length
            // ------------------------------------------------
            List();


        }

        static void Array()
        {

            // declaration
            string[] arr1 = new string[3];
            arr1[0] = "AAA";
            arr1[1] = "BBB";
            arr1[2] = "CCC";
            // arr1[3] = "DDD"; // THIS IS NOT POSSIBLE
            Console.WriteLine(arr1);
            Console.WriteLine(arr1.GetType());

            // declaration + initialization
            string[] arr2 = new string[3] { "AAA", "BBB", "CCC" };
            Console.WriteLine(arr2);
            Console.WriteLine(arr2.GetType());

            // declaration + initialization
            string[] arr3 = { "AAA", "BBB", "CCC" };
            Console.WriteLine(arr3);
            Console.WriteLine(arr3.GetType());


            // Array length
            Console.WriteLine(arr3.Length);
        }

        static void List()
        {





        }
    }
}
