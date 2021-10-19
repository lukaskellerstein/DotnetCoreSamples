using System;

namespace TestApp
{
    class Class1
    {
        private MyLogger logger { get; set; }


        public Class1()
        {
            logger = new MyLogger();
            logger.Log("Initializing Class1"); //<- Very easy to change
        }

        public void doSomething()
        {
            logger.Log("doSomething in Class1"); //<- Very easy to change
        }
    }
}