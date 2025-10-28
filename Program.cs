using System.Linq;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        // Я когда альтабался поменять музыку забыл потом снять с паузы
        //Надеюсь что простите, тут ничего такого сложного не было просто структуры из лабы писал и всё
        // Тут и так всё что я написал за это время видно что писал сам по времени коммитов, буду повнимательнее вредь
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 9, 4, 7, 3, 8, 23, 45, 12, 34, 13, 98, 67, 56, 99 };
            List<int> evenNumbers = new List<int>();
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                    evenNumbers.Add(n);
            }
            List<int> multiplied = new List<int>();
            foreach (var n in evenNumbers)
            {
                multiplied.Add(n * 10);
            }
            multiplied.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("Result (without LINQ):");
            foreach (var n in multiplied)
            {
                Console.WriteLine(n);
            }

            var res = numbers
                .Where(n => n % 2 == 0)
                .Select(n => n * 10)
                .OrderByDescending(n => n);
            foreach(var n in res){
                Console.WriteLine(n);
            }
            Console.WriteLine();

            List<string> names = new List<string> { "Anna", "Ivan", "Maria", "P'etr" };
            List<string> longNames = new List<string>();
            foreach (var n in names)
            {
                if (n.Length > 4)
                    longNames.Add(n);
            }
            foreach (var n in longNames)
            {
                Console.WriteLine(n);
            }
            var linqLongNames = names.Where(name => name.Length > 4);
            foreach (var n in linqLongNames)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            List<int> nums = new List<int> { 10, 5, 20, 3 };
            int min = nums[0];
            foreach(var n in nums)
            {
                if (n < min)
                    min = n;
            }
            Console.WriteLine($"\nMiimum number without LINQ: {min}");
            int linqMin = nums.Min();
            Console.WriteLine($"\nMiimum number with LINQ: {linqMin}");
            Console.WriteLine();

            List<int> numes = new List<int> { 1, 2, 3, 4 };
            List<int> squares = new List<int>();
            foreach (var n in numes)
            {
                squares.Add(n * n);
            }
            Console.WriteLine("\n Squares of numbers without LINQ:");
            Console.WriteLine(string.Join(", ", squares));
            var linqSquares = numes.Select(n => n * n);
            Console.WriteLine("\n Squares of numbers with LINQ:");
            Console.WriteLine(string.Join(", ", linqSquares));
            Console.WriteLine();


            List<Student11> students = new()
            {
                new Student11 { Name = "Andrew", Score = 90 },
                new Student11 { Name  = "Vika", Score = 78 },
                new Student11 { Name = "Denis", Score = 84 },
                new Student11 { Name = "Lena", Score = 95 },
                new Student11 { Name = "Oleg", Score = 65 },
                new Student11 { Name = "Grisha", Score = 100 },
            };
            List<Student11> goodStudents = new List<Student11>();
            int total = 0;
            foreach( var s in students)
            {
                total += s.Score;
                if (s.Score > 80)
                    goodStudents.Add(s);
            }
            goodStudents.Sort((a, b) => a.Name.CompareTo(b.Name));
            Console.WriteLine("Students with score above 80:");
            foreach (var s in goodStudents)
            {
                Console.WriteLine($"{s.Name} - {s.Score}");
            }
            Console.WriteLine($"Average score: {(double)total / students.Count:F1}");
            Console.WriteLine("With LINQ ");
            var gooodStudents = students
                .Where(s => s.Score > 80)
                .OrderBy(s => s.Name);
            var avgscore = students.Average(s => s.Score);
            Console.WriteLine("Students with score above 80:");
            foreach (var s in gooodStudents)
                Console.WriteLine($"{s.Name} - {s.Score}");
            Console.WriteLine($"Average score: {avgscore:F1}");





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
    }
    class Student11()
    {
        public string Name;
        public int Score;
    }
}
