using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    abstract class Animal{
        public string? Name { get; set; }
        public abstract void MakeSound();
        public void Info() => Console.WriteLine($"Animal: {Name}");
    }
}
