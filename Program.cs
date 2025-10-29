using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> items = new List<IPrintable>
            {
                new Bookdz("War and peace", "Lev Tolstoi"),
                new Bookdz("Stainless steel rat", "Harry Harrison"),
                new Magazine("Forbes", 27),
                new Magazine("National Geographic", 11),
            };

            foreach (var it in items)
            {
                it.PrintInfo();
            }



        }



        //static void Main(string[] args)
        //static async Task Main()
    }

}
