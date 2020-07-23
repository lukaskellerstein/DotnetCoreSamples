using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write Line
            Console.WriteLine("Hello World!");

            // Read Line
            // Console.ReadLine();

            // ***************************************************
            // ***************************************************
            // PRIMITIVE TYPES
            // value types = variable contains direct value
            // ***************************************************
            // ***************************************************
            PrimitiveTypes();

            // +
            // Enum
            Enum();
            // Struct
            Struct();


            // ***************************************************
            // ***************************************************
            // REFERENCE TYPES
            // = variable are just refernce to the memory where value is stored
            // ***************************************************
            // ***************************************************

            // class


        }


        static void PrimitiveTypes()
        {
            // -------------------------------------
            // Typed variable
            // -------------------------------------

            // Boolean
            bool bool1 = true;

            // INTEGER ***************************
            int num1 = 5;

            // DOUBLE vs. DECIMAL ****************
            double d1 = 0.555;
            decimal d2 = 0.555m;

            // STRING ****************************
            string str1 = "AAAA";

            // string interpolation
            string str2 = $"Some text: {str1}";

            // Search string
            string str3 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin tellus tortor, sodales non tristique nec, condimentum non purus. Cras mollis leo justo, vitae vehicula risus interdum a. Sed luctus iaculis ligula. Mauris eget pellentesque ante, ut aliquet urna. In egestas justo sit amet sapien consectetur pretium. Integer lacinia convallis porta. Aenean quis elementum nunc. Mauris at diam lobortis, porta augue nec, tincidunt quam. Nunc tempor vitae metus vitae imperdiet. Maecenas quis dolor ullamcorper, congue magna quis, hendrerit lacus. Vivamus sapien risus, rutrum et porttitor nec, sollicitudin vel lectus. Aliquam sagittis nisi a magna suscipit, eget commodo ipsum ullamcorper. Sed vitae mi non urna euismod hendrerit.";
            var res1 = str3.IndexOf("dolor");

            // Upper, Lower
            var res2 = str3.ToUpper();
            var res3 = str3.ToLower();

            // Index string
            var res4 = str3[10];

            // CHAR ******************************
            char ch1 = 'O';





            // -------------------------------------
            // Dynamic type variable
            // -------------------------------------
            var aaa0 = true;
            var aaa1 = 5;
            var aaa2 = 0.555;
            var aaa3 = 0.555;
            var aaa4 = "abcd";
            var aaa5 = 'O';


            // -------------------------------------
            // Constants
            // -------------------------------------

            const int c1 = 5;
            const string t1 = "text1";
            const bool b1 = false;
        }




        static void Enum()
        {

        }

        static void Struct()
        {
            Str1 str1;
            str1.name = "Joe";
            str1.age = 44;
            str1.doSomething();
            Console.WriteLine(str1.getSomething());


            Str2 str2 = new Str2("Joe", 44);
            str2.doSomething();
            Console.WriteLine(str2.getSomething());

            Str3 str3 = new Str3();
            str3.name = "Joe";
            str3.age = 44;
            str3.doSomething();
            Console.WriteLine(str3.getSomething());
        }
    }

    // Enum *************************************************
    enum En1
    {
        CAR,
        AIRPLANE,
        BOAT,
        WALK
    }


    enum En2 : int // cannot use string although
    {
        AAA = 1,
        BBB = 2
    }

    // Struct ***********************************************

    // Struct = Immutable object
    // Class = Mutable object

    /*
    CONSIDER defining a struct instead of a class if 
    instances of the type are small and commonly short-lived 
    or are commonly embedded in other objects.
    */

    /*
    - structures do not support inheritance
    - structures cannot have default constructor
    - structure can implement one or more interfaces
    - structure members cannot be specified as abstract, virtual, or protected
    - structure doesn't need "new" keyword for instantiating
    */

    struct Str1
    {
        public string name;
        public int age;

        public void doSomething()
        {
            Console.WriteLine("doing...");
        }

        public string getSomething()
        {
            return this.name;
        }
    }

    public struct Str2
    {
        public Str2(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;

        public void doSomething()
        {
            Console.WriteLine("doing...");
        }

        public string getSomething()
        {
            return this.name;
        }
    }

    struct Str3
    {
        //- structures cannot have default constructor
        public Str3()
        {
            this.name = "Joe";
            this.age = 44;
        }

        public string name;
        public int age;

        public void doSomething()
        {
            Console.WriteLine("doing...");
        }

        public string getSomething()
        {
            return this.name;
        }
    }



}
