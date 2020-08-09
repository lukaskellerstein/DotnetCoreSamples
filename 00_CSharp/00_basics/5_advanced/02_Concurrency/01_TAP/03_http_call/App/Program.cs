using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add a using directive and a reference for System.Net.Http;
using System.Net.Http;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The display lines in the example lead you through the control shifts.
            Console.WriteLine("ONE:   Entering startButton_Click.\r\n" +
                "           Calling AccessTheWebAsync.\r\n");

            Task<int> getLengthTask = AccessTheWebAsync();

            Console.WriteLine("\r\nFOUR:  Back in startButton_Click.\r\n" +
                "           Task getLengthTask is started.\r\n" +
                "           About to await getLengthTask -- no caller to return to.\r\n");

            int contentLength = await getLengthTask;

            Console.WriteLine("\r\nSIX:   Back in startButton_Click.\r\n" +
                "           Task getLengthTask is finished.\r\n" +
                "           Result from AccessTheWebAsync is stored in contentLength.\r\n" +
                "           About to display contentLength and exit.\r\n");

            Console.WriteLine($"\r\nLength of the downloaded string: {contentLength}.\r\n");
        }
        static async Task<int> AccessTheWebAsync()
        {
            Console.WriteLine("\r\nTWO:   Entering AccessTheWebAsync.");

            // Declare an HttpClient object.
            HttpClient client = new HttpClient();

            Console.WriteLine("\r\n           Calling HttpClient.GetStringAsync.\r\n");

            // GetStringAsync returns a Task<string>.
            Task<string> getStringTask = client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");

            Console.WriteLine("\r\nTHREE: Back in AccessTheWebAsync.\r\n" +
                "           Task getStringTask is started.");

            // AccessTheWebAsync can continue to work until getStringTask is awaited.

            Console.WriteLine("\r\n           About to await getStringTask and return a Task<int> to startButton_Click.\r\n");

            // Retrieve the website contents when task is complete.
            string urlContents = await getStringTask;

            Console.WriteLine("\r\nFIVE:  Back in AccessTheWebAsync." +
                "\r\n           Task getStringTask is complete." +
                "\r\n           Processing the return statement." +
                "\r\n           Exiting from AccessTheWebAsync.\r\n");

            return urlContents.Length;
        }
    }
}
