using System;

namespace App
{

    static class MyEnum
    {
        public static void Run()
        {

            En1 vehicles = En1.AIRPLANE | En1.CAR | En1.BOAT;

            Console.WriteLine(vehicles);

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

}