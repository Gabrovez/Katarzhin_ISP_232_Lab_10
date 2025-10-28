using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    public class Duck : IFlier, ISwimer
    {
        public void Fly() => Console.WriteLine("Duck is flying!");
        public void Swim() => Console.WriteLine("Duck is swiming!");
            
    }

    public interface IFlier
    {
        void Fly();
    }

    public interface ISwimer
    {
        void Swim();
    }



}
