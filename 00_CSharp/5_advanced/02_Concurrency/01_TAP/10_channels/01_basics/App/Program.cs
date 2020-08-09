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

            var chan1 = Channel.CreateUnbounded<string>();


            var chanStage1 = await Stage1(chan1.Writer);
            await Stage2(chan1);


            while (await chan1.Reader.WaitToReadAsync())
            {
                var aa = await chan1.Reader.ReadAsync();
                System.Console.WriteLine(aa);

            }

        }


        static async ChannelReader<string> Stage1(ChannelWriter<string> ch)
        {
            await ch.WriteAsync("Stage 1 - message 1");
            await ch.WriteAsync("Stage 1 - message 2");
            ch.Complete();
        }

        static async void Stage2(Channel<string> ch)
        {

            while (await ch.Reader.WaitToReadAsync())
            {
                var aa = await ch.Reader.ReadAsync();
                System.Console.WriteLine(aa);

                await ch.Writer.WriteAsync("Stage 2 - message 1");
            }


        }
    }
}
