using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class logowanie
    {
        private string login;
        private string haslo;
        public logowanie(string login, string haslo)
        {
            this.login = login;
            this.haslo = haslo;
        }
        public void poprawnosc()
        {
            int i = 0;
            Console.WriteLine("Podaj logi");
            string tempLogin = Console.ReadLine();
            Console.WriteLine("Podaj haslo");
            string tempPass = Console.ReadLine();
            i++;
            while ((i<5)&&(tempPass != this.haslo))
            {
                i++;
                Console.WriteLine("Pozostało" + (5 - i + 1) + " prób.");

            }
        }
            }
}
