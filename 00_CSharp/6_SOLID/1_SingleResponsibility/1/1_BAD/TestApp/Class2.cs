using System;

namespace TestApp
{
    class Class2
    {

        public Class2()
        {
            Console.WriteLine("Initializing Class2"); // <--- now is problematic to change a logging, cause I have to do it in each class
        }

        public void doSomething()
        {
            Console.WriteLine("doSomething in Class2"); // <--- now is problematic to change a logging, cause I have to do it in each class
        }
    }
}