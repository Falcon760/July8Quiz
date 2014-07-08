
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = new string [] {"Frank", "Pete", "Jack", "Violet", "Fred", "Barney"};
            var x = v.Take(5);
            Console.WriteLine(x);
            Console.ReadLine();


        }
    }
}
