namespace App
{

    static class MyMethods
    {

        /*
        "REF" is used to state that the parameter passed may be modified by the method.

        "IN" is used to state that the parameter passed cannot be modified by the method.

        "OUT" is used to state that the parameter passed must be modified by the method.
        */


        public static void Run()
        {

            var help = new Helper();

            var text = "INIT TEXT";

            System.Console.WriteLine(text);
            help.DoSomething1(text);
            System.Console.WriteLine(text);

            System.Console.WriteLine(text);
            help.DoSomething2(ref text);
            System.Console.WriteLine(text);

            System.Console.WriteLine(text);
            help.DoSomething3(out text);
            System.Console.WriteLine(text);

            System.Console.WriteLine(text);
            var text2 = help.DoSomething4(text);
            System.Console.WriteLine(text);
            System.Console.WriteLine(text2);

        }
    }


    class Helper
    {

        // simple method
        public void DoSomething1(string text)
        {
            System.Console.WriteLine(text);
            text = "CHANGED 1";
            System.Console.WriteLine(text);
        }

        // method with ref parameter
        public void DoSomething2(ref string text)
        {
            System.Console.WriteLine(text);
            text = "CHANGED 2";
            System.Console.WriteLine(text);
        }

        // method with out parameter
        public void DoSomething3(out string text)
        {
            // System.Console.WriteLine(text);
            text = "CHANGED 3";
            System.Console.WriteLine(text);
        }

        // method with return 
        public string DoSomething4(string text)
        {
            System.Console.WriteLine(text);
            text = "CHANGED 4";
            System.Console.WriteLine(text);
            return text;
        }



    }
}