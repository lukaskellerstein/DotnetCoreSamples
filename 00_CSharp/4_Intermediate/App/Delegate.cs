using System;
namespace App
{

    // -------------------------------------------------
    // C# also provides a built-in generic delegates 
    // - Action, Func, Predicate. 
    //
    // We can use them if we don't want to create our own delegate.
    //
    //
    // ACTION - doesn't return anything
    // FUNC - return something
    // PREDICATE - return only boolean
    // -------------------------------------------------
    static class MyDelegate
    {

        // Declaration
        static Action<string> act1 { get; set; }
        static Func<string, string> func1;
        static Predicate<string> pred1;

        public static void Run()
        {



            // Declaration and initialization
            Action act0 = () => Console.WriteLine("Some static text");
            Action<string> act1 = PrintSomething;
            Action<string> act2 = (text) => Console.WriteLine("BUUUUU = " + text);

            Func<string, string> func1 = SomeMethod;
            Func<string, string> func2 = (text) => text.ToUpper();
            Func<string, string> func3 = (text) =>
            {
                var aaa = 5;
                var result = text.ToUpper();
                return result;
            };
            Func<int, int, int> Sum = (x, y) => x + y;

            Predicate<string> pred0 = (text) => true;
            Predicate<string> pred1 = IsExistSomething;
            Predicate<string> pred2 = (text) =>
            {
                var aaa = 5;
                var result = text.Contains("EXIST");
                return result;
            };

            // Calling
            act0();
            act1("ooooooooooooooooooo");
            act2("ooooooooooooooooooo");
            func1("ooooooooooooooooooo");
            func2("ooooooooooooooooooo");
            func3("ooooooooooooooooooo");
            Sum(1, 2);
            pred0("oooooooooooooooooooEXIST");
            pred1("oooooooooooooooooooEXIST");
            pred2("oooooooooooooooooooEXIST");
        }

        static void PrintSomething(string text)
        {
            Console.WriteLine("HAHAHAHHA = " + text);
        }

        static string SomeMethod(string name)
        {
            return name.ToUpper();
        }

        static bool IsExistSomething(string text)
        {
            return text.Contains("EXIST");
        }


    }



}