using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new();
            arena.AddUnit(new Warrior("Ragnar"));
            arena.AddUnit(new Mage("Gendalf"));
            arena.AddUnit(new Archer("Legolas"));
            arena.StartBattle();
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
