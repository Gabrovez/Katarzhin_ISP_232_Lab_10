using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    internal interface ISound{
        void MakeSound();
    }
    public class Bird : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Chirp!");
        }
    }
    public class Phone : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Ding-Ding!");
        }
    }
}
