using System;

namespace App
{

    static class MyTuple
    {
        // Tuples = Anonymous Immutable object
        // Struct = Immutable object
        // Class = Mutable object

        public static void Run()
        {
            // without names
            (double, int) t1 = (4.5, 3);
            Console.WriteLine(t1);

            // with names
            (string id, string name, int age, string role) t2 = ("123-2342-243-234-2", "Joe Black", 40, "Software Engineer");
            Console.WriteLine(t2);
            Console.WriteLine(t2.id);
            Console.WriteLine(t2.name);

            // Main use case is to create lighweight structure, 
            // without need to create a class
            var t3 = getNewEmployee();


            // Deconstruction
            var (id, name, role, age) = t2;
            var (id2, _, _, role2) = t2;

            // TEST Mutability
            TestMutability(t2);
            Console.WriteLine(t2);
        }

        static (string id, string name, int age, string role) getNewEmployee()
        {
            Helpers help = new Helpers();
            return (id: Guid.NewGuid().ToString(), name: help.RandomString(10), age: help.RandomNumber(18, 60), role: "Newcomer");
        }

        static string IdentifyPerson((string id, string name, int age, string role) person)
        {
            return $"TUPLE: [{person.id}] - My name is {person.name} and my role in the world is {person.role}";
        }

        static void TestMutability((string id, string name, int age, string role) person)
        {
            person.role = "ROLE IS CHANGED";
        }
    }

}