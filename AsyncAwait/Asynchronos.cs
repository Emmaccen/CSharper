using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.AsyncAwait
{
    class Asynchronos
    {
        public async static void Run()
        {
            //DoIntensiveTask();
            Task<string> data = DoIntensiveAsysncronosTaks();
            Console.WriteLine("\nDoing other stuffs...");
            string result = await data;
        }

        public static void DoIntensiveTask()
        {
            Console.Write("Doing some really really long stuff");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write('.');
            }
        }
        public static async Task<string> DoIntensiveAsysncronosTaks()
        {
            Console.WriteLine("fetching...");
            Asynchronos fetchDatabase = new Asynchronos();
            return await fetchDatabase.ReturnResponse("https://google.com");
            
        }
        public Task<string> ReturnResponse(string url)
        {
            /*return new Task<string>(() => {
            Thread.Sleep(3000);
            return "Fetching from database done!";
            });*/
            Thread.Sleep(3000);
            return Task.FromResult("Hello, world. From Google.com");
        }
    }
}
