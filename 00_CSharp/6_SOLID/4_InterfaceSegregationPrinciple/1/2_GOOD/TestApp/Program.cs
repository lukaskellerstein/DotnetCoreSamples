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
        }
        interface IMovable
        {
            void move();
        }
        interface IFlyable
        {
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
        }
        class ToyPlane : IToy, IMovable, IFlyable
        {
            double price;
            String color;
            public void setPrice(int price)
            {
                this.price = price;
            }
            public void setColor(String color)
            {
                this.color = color;
            }
            public void move()
            {//code related to moving plane

            }

            public void fly()
            {// code related to flying plane

            }
        }
    }
}
