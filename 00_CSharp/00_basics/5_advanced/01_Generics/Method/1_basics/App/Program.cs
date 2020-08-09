using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock1 = new Stock("AAPL", "Technology", "Product Manufacturer");
            Option opt1 = new Option();

            // No Generic
            var testRepo1 = new TestRepository1();
            testRepo1.Save(stock1);
            // testRepo1.Save(opt1);

            // Generic method
            var testRepo2 = new TestRepository2();
            testRepo2.Save<Stock>(stock1);
            // testRepo2.Save<Stock>(opt1);

            // Generic class
            var testRepo3 = new TestRepository3<Stock>();
            testRepo3.Save(stock1);
            // testRepo3.Save(opt1);
        }
    }


    class TestRepository1
    {
        public void Save(Asset item)
        {
            System.Console.WriteLine($"Saving...{item.ToString()}");
        }
    }

    class TestRepository2
    {
        public void Save<T>(T item) where T : Asset
        {
            System.Console.WriteLine($"Saving...{item.ToString()}");
        }
    }

    class TestRepository3<T> where T : Asset
    {
        public void Save(T item)
        {
            System.Console.WriteLine($"Saving...{item.ToString()}");
        }
    }
}
