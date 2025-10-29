using System;
using System.Linq;
using System.Net.Cache;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        public static async Task LoadStudentsAsync()
        {
            Console.WriteLine("Data is loading....");
            await Task.Delay(3000);
            Console.WriteLine("Data is ready");
        }
        static async Task Main()
        {
            List<Studentdz> students = new()
            {
                new Studentdz ("Andrei", 18, "ISP-231"),
                new Studentdz ("Vika", 19, "ISP-233"),
                new Studentdz ("Denis", 20, "USP-232"),
                new Studentdz ("Lena", 21, "USP-232" ),
                new Studentdz ("Grisha", 22, "ISP-232" )
            };

            List<Teacher> teachers = new()
            {
                new Teacher ("Anton", 28, "ISP"),
                new Teacher ("Lera", 25, "ISP"),
                new Teacher ("Oleg", 23, "USP"),
            };
            await LoadStudentsAsync();
            Console.WriteLine();    

            var studover20 = students.Where(s => s.Age > 20).ToList();
            studover20.Sort((s1,s2) => string.Compare(s1.Name, s2.Name));
            foreach (var s in studover20)
            {
                s.GetDescription();
            }
            Console.WriteLine();
            var teacherop = teachers.Where(s => s.Department == "ISP").ToList();
            teacherop.Sort((s1, s2) => string.Compare(s1.Name, s2.Name));//Я только щас подумал что можно было order by, но он и так правильно выводит так переписывать не стану уже
            foreach (var t in teacherop)
            {
                t.GetDescription();
            }


        }



        //static void Main(string[] args)
        //static async Task Main()
    }

}
