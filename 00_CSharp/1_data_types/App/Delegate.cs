namespace App
{


    static class MyDelegate
    {

        // -------------------------------------------------
        // DELEGATE is way how we can keep a method in variable
        // and call it later/when it's necessary
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
        // -------------------------------------------------

        // Declaration
        public delegate string UpperDelegate(string text);


        public static void Run()
        {
            // Instantiation 1 - declared function
            UpperDelegate updel = new UpperDelegate(SomeMethod);
            // calling a method/delegate
            updel("aaa");

            // Instantiation 2 - anonymous function
            UpperDelegate updel2 = (name) => { return name.ToUpper(); };


            // Usage in methods as parameter - declared function
            var result = UsageOfDelegate("Lukas", SomeMethod);
            // Usage in methods as parameter - anonymous function
            var result2 = UsageOfDelegate("Lukas", (name) => { return name.ToUpper(); });

        }

        static string SomeMethod(string name)
        {
            return name.ToUpper();
        }

        static string UsageOfDelegate(string name, UpperDelegate method)
        {
            return method(name);
        }


    }



}