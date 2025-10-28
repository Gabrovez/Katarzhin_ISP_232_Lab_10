using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    internal interface INamed
    {
        string Name { get; set; }
    }

    public class Book : INamed
    {
        public string Name { get; set; }
    }
}
