using System;
using System.Threading;

namespace App
{

    // -------------------------------------------------------
    // EVENTS - Represents a method call in my class (publisher)
    // which can be subscribed by other classes (subscriber)
    //
    // Difference between Delegate and Event is:
    //
    // - Delegate NEED TO have a subscriber/method to call. 
    //   Ex. LINQ Query: customers.Where(c => c.City == "London");
    // - Event do NOT NEED TO have a subscriber/method to call.
    //   Ex. Button.click 
    //
    // - Delegate is mostly short-lived 
    //   Ex. LINQ Query
    // - Event (listener/subscriber) is mostly long-lived subscriber 
    //   Ex. Button.click
    // -------------------------------------------------------

    static class MyEvents
    {

        public static void Run()
        {

            var mycp1 = new MyComponent();

            // -----------------------------------------
            // ANONYMOUS Lambda
            // -----------------------------------------

            // Subscribe to the event
            mycp1.UserSelected += (sender, eventArgs) =>
            {
                Console.WriteLine("Log Event - UserSelected in MyEvents class");
                Console.WriteLine(eventArgs);
            };

            // ANONYMOUS - CANNOT UNSUBSCRIBE !!!!

            // -----------------------------------------
            // NON-ANONYMOUS Lambda
            // -----------------------------------------

            // Declaration
            EventHandler<string> handler = (sender, eventArgs) =>
            {
                Console.WriteLine("Log Event 2 - UserSelected in MyEvents class");
                Console.WriteLine(eventArgs);
            };

            // Subscribe to the event
            mycp1.UserSelected += handler;

            // Usubscribe to the event
            mycp1.UserSelected -= handler;

        }


    }


    class MyComponent
    {
        //-----------------------------------------
        // Declaration of EventHandler
        //
        // EventHandler is built-in delegate
        //-----------------------------------------
        public event EventHandler<string> UserSelected;

        public MyComponent()
        {
            StartTimer(2000);

        }

        public void StartTimer(int dueTime)
        {
            Timer t = new Timer(new TimerCallback(TimerProc));
            t.Change(dueTime, 0);
        }

        private void TimerProc(object state)
        {
            // The state object is the Timer object.
            Timer t = (Timer)state;
            t.Dispose();
            Console.WriteLine("The timer callback executes.");

            //-----------------------------------------
            // INVOKE A EVENT
            //-----------------------------------------
            UserSelected?.Invoke(this, "User1");
        }

    }

}