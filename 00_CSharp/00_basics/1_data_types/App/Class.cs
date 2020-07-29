using System;

namespace App
{

    static class MyClass
    {
        // Class = Mutable object
        // Tuples = Anonymous Immutable object
        // Struct = Immutable object

        public static void Run()
        {

            var p1 = new Person("John Wayne", "Actor");
            Console.WriteLine(p1.IdentifyYourself());

            // TEST Mutability
            TestMutability(p1);
            Console.WriteLine(p1.IdentifyYourself());

        }

        static void TestMutability(Person person)
        {
            person.role = "ROLE IS CHANGED";
        }

    }



    /*
    Encapsulation is implemented by using access specifiers. An access specifier defines the scope and visibility of a class member. C# supports the following access specifiers −

    Public
    Private
    Protected
    Internal
    Protected internal
    */
    class Person
    {

        string id { get; set; }
        string name { get; set; }
        public string role { get; set; }

        // Constructor
        public Person(string name, string role)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
            this.role = role;
        }
        // Desctructor
        ~Person()
        {
            // clean what is necessary
        }

        // Method
        public string IdentifyYourself()
        {
            return $"CLASS: [{id}] - My name is {name} and my role in the world is {role}";
        }
    }

}