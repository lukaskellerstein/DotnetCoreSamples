namespace App
{

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