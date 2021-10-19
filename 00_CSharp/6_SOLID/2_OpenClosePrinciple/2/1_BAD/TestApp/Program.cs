using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }


    public class AreaCalculator
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle) //<-- THIS IS WRONG => NEEDS MODIFICATION
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else //<-- THIS IS WRONG => NEEDS MODIFICATION
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
