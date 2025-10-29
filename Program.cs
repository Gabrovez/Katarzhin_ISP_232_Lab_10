using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string> {"Moscow", "Volzhsky", "Sochi", "Anapa", "Kazan'", "Kaliningrad", "Krasnodar"};
            var citiesm = cities
                .Where(city => city.StartsWith("K") && city.Length > 6)
                .OrderBy(city => city.Length);
            foreach( var c in citiesm)
            {
                Console.WriteLine(c);
            }


        }



        //static void Main(string[] args)
        //static async Task Main()
    }

}
