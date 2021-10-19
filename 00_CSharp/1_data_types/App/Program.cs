using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write Line
            // Console.WriteLine("Hello World!");

            // Read Line
            // Console.ReadLine();

            // ***************************************************
            // ***************************************************
            // PRIMITIVE TYPES
            // value types = variable contains direct value
            // are stored in STACK
            // ***************************************************
            // ***************************************************
            PrimitiveTypes.Run();

            // +
            // Enum
            MyEnum.Run();
            // Struct
            MyStruct.Run();
            // Tuples
            MyTuple.Run();

            // ***************************************************
            // ***************************************************
            // REFERENCE TYPES
            // = variable are just refernce to the memory where value is stored
            // are stored in HEAP
            // ***************************************************
            // ***************************************************

            // Class
            MyClass.Run();

            // Interface
            MyInterface.Run();

            // Array
            MyArray.Run();

            // List
            MyList.Run();

            // Delegate
            MyDelegate.Run();
        }

    }





}
