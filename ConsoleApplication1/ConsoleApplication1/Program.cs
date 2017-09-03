using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int RandAdd(int num1, int num2)

        {

            Random rnd = new Random();

            int Number1 = rnd.Next(num1, num2);

            int Number2 = rnd.Next(num1, num2);

            Console.WriteLine(Number1 + " " + Number2);

            return Number1 + Number2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz zakres dwóch losowych liczb do zsumowania.");

            int Num1 = int.Parse(Console.ReadLine());

            int Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(RandAdd(Num1, Num2));

            Console.ReadKey();
        }
    }
}
