using System;

namespace TestApp
{
    class Class2
    {
        private MyLogger logger { get; set; }

        public Class2()
        {
            logger = new MyLogger();
            logger.Log("Initializing Class2"); //<- Very easy to change
        }

        public void doSomething()
        {
            logger.Log("doSomething in Class2"); //<- Very easy to change
        }
    }
}