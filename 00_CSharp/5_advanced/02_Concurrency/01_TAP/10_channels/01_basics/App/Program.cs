using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var chanStage1 = Stage1();
            var chanStage2 = Stage2(chanStage1);

            var resultText = "";
            await foreach (var item in chanStage2.ReadAllAsync())
            {
                Console.WriteLine($"Result from item: {item}");
                resultText += item;
            }

            Console.WriteLine($"RESULT: {resultText}");
        }


        static ChannelReader<string> Stage1()
        {
            var output = Channel.CreateUnbounded<string>();

            Task.Run(async () =>
            {
                await output.Writer.WriteAsync("Stage 1 - message 1");
                await output.Writer.WriteAsync("Stage 1 - message 2");
                output.Writer.Complete();
            });

            return output;
        }

        static ChannelReader<string> Stage2(ChannelReader<string> inputChannel)
        {

            var output = Channel.CreateUnbounded<string>();

            Task.Run(async () =>
            {
                await foreach (var text in inputChannel.ReadAllAsync())
                {
                    //do something
                    var text2 = "AAAA" + text;

                    await output.Writer.WriteAsync(text2);
                }
                output.Writer.Complete();
            });

            return output;
        }
    }
}
