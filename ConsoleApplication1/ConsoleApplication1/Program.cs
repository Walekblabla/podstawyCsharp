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
            System.Console.WriteLine("Ile masz lat?");

            string age;

            age = Console.ReadLine();

            Console.WriteLine("Mam " + age + " lat.");
            Console.ReadLine();

            System.Console.WriteLine("Jak masz na imię?");

            string name;

            name = Console.ReadLine();

            Console.WriteLine("Nazywam się " +name+ ".");
            Console.ReadLine();
        }
    }
}
