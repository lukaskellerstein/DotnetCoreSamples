using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = await GetTextAsync();

        }

        static async Task<string> GetTextAsync()
        {
            HttpClient http = new HttpClient();
            return await http.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
        }

    }
}
