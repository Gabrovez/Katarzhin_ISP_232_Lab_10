using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    public class Mage : IUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Mage(string name)
        {
            Name = name;
            Health = 80;
        }
        public void Attack(IUnit target)
        {
            Console.WriteLine($"{Name} cast firebal upon {target.Name}!");
        }
    }
}
