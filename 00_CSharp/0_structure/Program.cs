using System;
using _01_basics.MyFolder;

namespace _01_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mycl1 = new MyClass1();
            mycl1.text = "aaaa";
            Console.WriteLine(mycl1.text);

            var mycl2 = new MyClass2();
            mycl2.id = 12345;
            Console.WriteLine(mycl2.id);


        }
    }
}
