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
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Mnozenie");
                Console.WriteLine("3. Wyjscie");
                Console.WriteLine("4. Dzielenie");
				Console.WriteLine("Oj Adamku, ale namieszales");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 4)
                    break;
				// wersja poprawiona przez użytkownika Junih (B) - polecam się
            }
        }
    }
}
