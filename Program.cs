using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        delegate int MathOperation(int a, int b);
        static void Main(string[] args)
        {
            MathOperation add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));

            Func<int, int, int> sum = (a, b) => a + b;
            Console.WriteLine(sum(3, 7));

            Func<int, string> numberToWord = num =>
            {
                switch (num)
                {
                    case 1: return "one";
                    case 2: return "two";
                    default: return "too much";
                }
            };
            Console.WriteLine(numberToWord(2));
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
