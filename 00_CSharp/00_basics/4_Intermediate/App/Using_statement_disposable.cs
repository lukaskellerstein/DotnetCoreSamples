using System;

namespace App
{



    static class MyUsingStatementWithDisposableObject
    {

        public static void Run()
        {

            using (var disp = new DisposableDemoClass())
            {
                // Here disp exists
            }

            // After here disp is Disposed
        }

    }


    class DisposableDemoClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose called!");
        }
    }
}