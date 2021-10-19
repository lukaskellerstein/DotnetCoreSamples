using System;

namespace TestApp
{

    /*

    Common ways to identify violations of LS principles are as follows:

    1.       not implemented method in the subclass. Ex. throw Exception instead of implementing the method from parent class.
    
    2.       Subclass function overrides the base class method to give it new meaning.

    */

    public class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Circle(); //<-- VIOLATING OF A LSP (2.)
            Console.WriteLine(triangle.GetShape());
        }
    }

    public class Triangle
    {
        public virtual string GetShape() //<-- VIOLATING OF A LSP (2.) = allowing a subclass to override the method

        {
            return " Triangle ";
        }
    }

    public class Circle : Triangle
    {
        public override string GetShape() //<-- VIOLATING OF A LSP (2.) = Subclass function overrides the base class method to give it new meaning.
        {
            return "Circle";
        }
    }
}
