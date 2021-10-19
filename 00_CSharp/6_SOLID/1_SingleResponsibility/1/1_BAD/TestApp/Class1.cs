using System;

namespace TestApp
{
    class Class1
    {

        public Class1()
        {
            Console.WriteLine("Initializing Class1"); // <--- now is problematic to change a logging, cause I have to do it in each class
        }

        public void doSomething()
        {
            Console.WriteLine("doSomething in Class1"); // <--- now is problematic to change a logging, cause I have to do it in each class
        }
    }
}