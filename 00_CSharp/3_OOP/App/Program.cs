using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var test1 = new UIObject();
            var area = test1.GetArea(); //<- Extension method
        }
    }

    // EXTENSION METHOD !!!!
    static class MyExtensions
    {
        // EXTENSION METHOD !!!!
        public static int GetArea(this UIObject obj) //<- USING this !!!!
        {
            return obj.height * obj.width;
        }
    }
}
