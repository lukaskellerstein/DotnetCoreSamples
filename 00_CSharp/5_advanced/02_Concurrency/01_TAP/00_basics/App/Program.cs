using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {

            // CREATE 1
            var aa = await Task.Run(() =>
            {
                return "asynchronous text";
            });
            System.Console.WriteLine(aa);

            // CREATE 2 - from result
            var bb = await Task.FromResult<string>("not very asynchronous text");


            // CONTINUE WITH - CHAINING
            await Task.Run(() =>
            {
                return "asynchronous text";
            }).ContinueWith((Task<string> text) =>
            {
                Console.WriteLine(text.Result + " HAHAHAHA");
            });

            // WAIT FOR ALL TASKS
            string[] addrs = { "a@a.com", "b@b.com" };
            var asyncOps = from addr in addrs select SendMailAsync(addr);
            await Task.WhenAll(asyncOps);


            // WAIT FOR JUST FIRST FINISHED TASK
            var symbol = "AAPL";
            var recommendations = new List<Task<bool>>()
            {
                GetBuyRecommendation1Async(symbol),
                GetBuyRecommendation2Async(symbol),
                GetBuyRecommendation3Async(symbol)
            };
            Task<bool> recommendation = await Task.WhenAny(recommendations);
            if (await recommendation) BuyStock(symbol);


            // CANCELATION TOKEN
            var cts = new CancellationTokenSource(); // !!!!!!!!!!!!!!!!!!!!!
            var recommendations2 = new List<Task<bool>>()
            {
                GetBuyRecommendation1Async(symbol, cts.Token),
                GetBuyRecommendation2Async(symbol, cts.Token),
                GetBuyRecommendation3Async(symbol, cts.Token)
            };

            Task<bool> recommendation2 = await Task.WhenAny(recommendations2);
            cts.Cancel(); // !!!!!!!!!!!!!!!!!!!!!
            if (await recommendation2) BuyStock(symbol);

        }

        static async Task<string> SendMailAsync(string address)
        {
            await Task.Delay(1000);
            return "Sended";
        }

        static async Task<bool> GetBuyRecommendation1Async(string address) => false;
        static async Task<bool> GetBuyRecommendation1Async(string address, CancellationToken cancellationToken) => false;
        static async Task<bool> GetBuyRecommendation2Async(string address) => true;
        static async Task<bool> GetBuyRecommendation2Async(string address, CancellationToken cancellationToken) => false;
        static async Task<bool> GetBuyRecommendation3Async(string address) => false;
        static async Task<bool> GetBuyRecommendation3Async(string address, CancellationToken cancellationToken) => false;

        static void BuyStock(string symbol) { }
    }
}
