using System;
using System.Collections;
using System.Collections.Generic;

namespace TestApp1
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
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new GoldCustomer());
            Customers.Add(new Enquiry()); //error
        }
    }

    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabase
    {
        void Add();
    }
    class Enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
    class Customer : IDiscount, IDatabase
    {
        public virtual void Add()
        {
            // Database code goes here  
        }

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 10;
        }
    }

    class GoldCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 20;
        }
    }
}
