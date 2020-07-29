using System;

namespace App
{

    static class MyStruct
    {
        // Struct = Immutable object
        // Tuples = Anonymous Immutable object
        // Class = Mutable object

        public static void Run()
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
    // public Str3()
    // {
    //     this.name = "Joe";
    //     this.age = 44;
    // }

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

