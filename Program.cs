using System;
using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new {Name = "Grisha", Age = 18, Group = "ISP-232" };
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Group: {student.Group}");

            var students = new[]
            {
                 new {Name = "Grisha", Age = 19, Group = "ISP-232" },
                 new { Name = "Anton", Age = 20, Group = "ISP-202" },
                 new {Name = "Kirill", Age = 22, Group = "ESP-232" },
                 new {Name = "Oleg", Age = 15, Group = "ISP-282" },
                 new {Name = "Gosha", Age = 22, Group = "USP-222" },
            };
            Console.WriteLine("Student's Table");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("| {0, -10} | {1, -10} | {2, -10} | ", "Name", "Age", "Group");
            Console.WriteLine(new string('-', 40));
            foreach( var s in students)
            {
                Console.WriteLine("| {0, -10} | {1, -10} | {2, -10} | ", s.Name, s.Age, s.Group);
            }
            Console.WriteLine(new string('-', 40));
            // На случай если вас будет смущать как я сделал таблицу, то передавать так переменные и у вас на предмете было, а на расте мы так постоянно пишем 
            // Чёрточки так ставил ещё на питоне когда шахматы делал там знак между ними ставили, и добавил здесь скобочки и вышло что они работают




        }



        //static void Main(string[] args)
        //static async Task Main()
    }

}
