using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    public interface IUnit
    {
        string Name { get; }
        int Health { get; }
        void Attack(IUnit target);
    }
}
