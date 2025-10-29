using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Wainting for data...");
            int datar = await GetDataAsync();
            Console.WriteLine($"Result: {datar}");
            Console.WriteLine("Data ready!");
            



        }
        static async Task<int> GetDataAsync()
        {
            await Task.Delay(2000);
            return 11;
        }



        //static void Main(string[] args)
        //static async Task Main()
    }

}
