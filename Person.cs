using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    internal class Person
    {
        public string? Name { get; set; }
        public virtual void SayHello()
        {
            Console.WriteLine($"Hi, my name is {Name}!");
        }
    }
}
