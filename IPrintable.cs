using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_10
{
    public interface IPrintable
    {
        public void PrintInfo();
    }
    public class Bookdz : IPrintable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Bookdz(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}");
        }
    }

    public class Magazine : IPrintable
    {
        public string Title { get; set; }
        public int Issue { get; set; }

        public Magazine(string title, int issue)
        {
            Title = title;
            Issue = issue;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Magazine: {Title}, Issue: {Issue}");
        }
    }


}
