using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;


namespace ConsoleApp16
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            

            for (int i = 0; i < 10; i++)
            {
                var httpClient = httpClientFactory.CreateClient();
                var response = await httpClient .GetAsync("https://localhost:44350/weatherforecast").Result.Content.ReadAsStringAsync();
                Console.WriteLine(response);
                Console.WriteLine(Environment.NewLine);
                
            }

            Console.ReadLine();

        }
    }
}
