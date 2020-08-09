using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.ReadLine();

            var stock1 = new Stock("AAPL", "Technology", "Product Manufacture");
            stock1.HistData = Helpers.GenerateRandomData(1000);

            var stock2 = new Stock("GOOG", "Technology", "Web");
            stock2.HistData = Helpers.GenerateRandomData(1000);

            var stock3 = new Stock("TSLA", "Automotive", "Car Manufacture");
            stock3.HistData = Helpers.GenerateRandomData(1000);

            var fut1 = new Future("GC");
            fut1.HistData = Helpers.GenerateRandomFuturesData(3, 1000);
            var fut2 = new Future("SI");
            fut2.HistData = Helpers.GenerateRandomFuturesData(3, 1000);


            var stock1Stats = AssetStatisticsFactory<Stock>.Get(stock1);
            Console.WriteLine(stock1Stats);

            var stock2Stats = AssetStatisticsFactory<Stock>.Get(stock2);
            Console.WriteLine(stock2Stats);

            var fut1Stats = AssetStatisticsFactory<Future>.Get(fut1);
            Console.WriteLine(fut1Stats);


            Console.ReadKey(true);
        }
    }



}


