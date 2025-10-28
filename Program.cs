using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        // Я когда альтабался поменять музыку забыл потом снять с паузы
        //Надеюсь что простите, тут ничего такого сложного не было просто структуры из лабы писал и всё
        // Тут и так всё что я написал за это время видно что писал сам по времени коммитов, буду повнимательнее вредь
        static async Task Main()
        {
            Console.WriteLine("Started cooking the dinner...");
            await CookDinnerAsync();
            Console.WriteLine("Dinner is ready!");
        }
        public static async  Task<string> MakeSoupAsync()
        {
            Console.WriteLine("Started cooking the soup...");
            await Task.Delay(3000);
            return "Soup";
        }
        public static async Task<string> MakeSaladAsync()
        {
            Console.WriteLine("Started choping the salad...");
            await Task.Delay(1000);
            return "Salad";
        }
        public static async Task CookDinnerAsync()
        {
            Task<string> soupTaks = MakeSoupAsync();
            Task<string> saladTaks = MakeSaladAsync();
            string soup = await soupTaks;
            string salad = await saladTaks;
            Console.WriteLine($"Ready: {soup} and {salad}");

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
