using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    internal interface IPerson
    {
        public void GetDescription();
    }
    public class Studentdz : IPerson
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Group { get; set; }

        public Studentdz(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public void GetDescription()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Group: {Group}");
        }

    }
    public class Teacher : IPerson
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Department { get; set; }

        public Teacher(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }

        public void GetDescription()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }

    }








}
