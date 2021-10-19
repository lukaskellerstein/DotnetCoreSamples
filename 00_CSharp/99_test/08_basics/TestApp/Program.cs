using System;

namespace TestApp
{
    public class MyObject
    {
        public MyObject(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
    }
    public class Program
    {
        static void arrayMethod(int[] a)
        {
            int[] b = new int[5];
            a = b;
        }
        static void objectMethod(MyObject a)
        {
            MyObject b = new MyObject("Adam");
            a = b;
        }
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            arrayMethod(arr);
            Console.WriteLine(arr.Length);

            MyObject obj = new MyObject("Lukas");
            objectMethod(obj);
            Console.WriteLine(obj.name);
        }
    }

}
