using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int aa = 2;
                if (aa == 4)
                    break;
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. XAXAXA");
                Console.WriteLine("3. Mnozenie");
<<<<<<< HEAD
                Console.WriteLine("4. Wyjscie");
=======
                Console.WriteLine("4. Dzielenie");
>>>>>>> 833f5f0... Add div to menu
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 4)
                    break;

            }
        }
    }
}
