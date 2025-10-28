using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static IEnumerable<string> WaitCoroutine()
        {
            yield return "Wait ... 1 sec";
            yield return "Wait ... 2 sec";
        }
        /*static void Main(string[] args)
        {   
            foreach(var step in WaitCoroutine())
            {
                Console.WriteLine(step);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done!");
        }*/
        static async Task Main()
        {
            Console.WriteLine("Wait ... 2 seconds");
            await Task.Delay(2000);
            Console.WriteLine("Done!");
        }









        static IEnumerable<int> GenerateNumbers()
        {
            Console.WriteLine("Starting generation...");
            yield return 1;

            Console.WriteLine("Pause...");
            yield return 2;

            Console.WriteLine("And one more time...");
            yield return 3;

            Console.WriteLine("Done!");
        }
        //static void Main(string[] args)
        //static async Task Main()
    }

}
