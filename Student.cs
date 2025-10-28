using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    class Student :Person {
        public string? University { get; set; }
        public override void SayHello()
        {
            Console.WriteLine($"Hi! I {Name}, studying in {University}.");
        }
    }
}
