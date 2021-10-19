using System;

namespace TestApp
{

    /*

    Common ways to identify violations of LS principles are as follows:

    1.       not implemented method in the subclass. Ex. throw Exception instead of implementing the method from parent class.
    
    2.       Subclass function overrides the base class method to give it new meaning.

    */

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
            Console.WriteLine(shape.GetShape());
            shape = new Triangle();
            Console.WriteLine(shape.GetShape());
        }
    }

    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
