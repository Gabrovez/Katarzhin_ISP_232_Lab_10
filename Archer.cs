using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    public class Archer : IUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Archer(string name)
        {
            Name = name;
            Health = 120;
        }
        public void Attack(IUnit target)
        {
            Console.WriteLine($"{Name} shoots a bow at {target.Name}!");
        }
    }
}
