using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        class Person

    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public DateTime BirthDate { get; set; }
    }
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            Console.WriteLine("Enter Birthday: ");
            string x = Console.ReadLine();

            if (x > "01-01-1900" && < "12-31-2014")
            {
            Person y;
                y.Age = x.ToChar;
                Console.WriteLine("His age is {0}", newPerson.Age);

            }
        }
    }
}

