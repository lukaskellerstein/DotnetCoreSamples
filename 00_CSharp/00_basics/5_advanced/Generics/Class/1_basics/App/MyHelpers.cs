using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{


    public static class Helpers
    {

        public static List<(string contractMonth, DateTime date, double price)> GenerateRandomFuturesData(int contractMonthsCount, int barsCount)
        {
            List<(string contractMonth, DateTime date, double price)> result = new List<(string contractMonth, DateTime date, double price)>();

            foreach (var item in Enumerable.Range(0, contractMonthsCount))
            {
                var contractMonth = RandomString(10);
                var bbb = Enumerable.Range(0, barsCount).Select(x => (contractMonth, new DateTime(2020, 1, 1), (double)new Random().Next(1, 1000))).ToList();

                result.AddRange(bbb);
            }

            return result;

        }


        public static List<(DateTime date, double price)> GenerateRandomData(int count) => Enumerable.Range(0, count).Select(x => (new DateTime(2020, 1, 1), (double)new Random().Next(1, 1000))).ToList();




        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}