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
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new GoldCustomer());
            Customers.Add(new Enquiry());

            foreach (Customer o in Customers)
            {
                o.Add(); //throw exception for Enquiry
            }
        }
    }

    class Customer
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

    class Enquiry : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 5;
        }

        public override void Add()
        {
            throw new Exception("Not allowed"); //<-- VIOLATING OF A LSP (1.)
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
