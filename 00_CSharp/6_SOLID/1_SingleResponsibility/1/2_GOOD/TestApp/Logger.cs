using System;

namespace TestApp
{
    class MyLogger
    {

        public void Log(string text)
        {
            Console.WriteLine(text); //<- change will happened on one place
        }

    }
}