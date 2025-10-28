using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    public class Arena
    {
        private List<IUnit> _units = new();

        public void AddUnit(IUnit unit)
        {
            _units.Add(unit);
        }
        public void StartBattle()
        {
            Console.WriteLine("The battle has begun!");
            foreach(var acker in _units)
            {
                foreach(var defer in _units)
                {
                    if (acker != defer)
                        acker.Attack(defer);
                }
            }
        }
    }
}
