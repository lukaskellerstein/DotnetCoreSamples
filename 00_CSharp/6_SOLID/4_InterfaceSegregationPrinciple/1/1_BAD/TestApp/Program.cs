using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        interface IToy
        {
            void setPrice(int price);
            void setColor(String color);
            void move();
            void fly();
        }
        class ToyHouse : IToy
        {
            int price;
            String color;
            public void setPrice(double price)
            {
                this.price = price;
            }
            public void setColor(String color)
            {
                this.color = color;
            }
            public void move()
            {
                throw new Exception("Not allowed"); //<-- VIOLATION OF ISP (Interface Segregation Principle)
            }
            public void fly()
            {
                throw new Exception("Not allowed"); //<-- VIOLATION OF ISP (Interface Segregation Principle)
            }
        }

        class ToyCar : IToy
        {
            int price;
            String color;
            int x;
            int y;
            public void setPrice(double price)
            {
                this.price = price;
            }
            public void setColor(String color)
            {
                this.color = color;
            }
            public void move()
            {
                this.x += 1;
                this.y += 1;
            }
            public void fly()
            {
                throw new Exception("Not allowed"); //<-- VIOLATION OF ISP (Interface Segregation Principle)
            }
        }

        class ToyPlane : IToy
        {
            int price;
            String color;
            int x;
            int y;
            public void setPrice(double price)
            {
                this.price = price;
            }
            public void setColor(String color)
            {
                this.color = color;
            }
            public void move()
            {
                throw new Exception("Not allowed"); //<-- VIOLATION OF ISP (Interface Segregation Principle)
            }
            public void fly()
            {
                this.x += 100;
                this.y += 100;
            }
        }
    }
}
