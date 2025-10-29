using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));

            List<int> evennumbers = numbers.FindAll(x => x % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evennumbers));

            List<int> threevennumbers = numbers.FindAll(x => x % 3 == 0);
            Console.WriteLine("Multiples of 3: " + string.Join(", ", threevennumbers));




        }



        //static void Main(string[] args)
        //static async Task Main()
    }

}
