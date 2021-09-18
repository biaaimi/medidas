using System;

namespace exercicios_etec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("digite um valor em metros para converter para KM e CM:");


            string metros = Console.ReadLine();
            double cmMetro = Convert.ToDouble(metros) * 100;
            double kmMetro = Convert.ToDouble(metros) / 1000;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nequivalência:");

            Console.WriteLine($"{cmMetro} cm\n{metros} m \n{kmMetro} km");

            Console.ReadKey();
            Console.ResetColor();
            
        }
    }
}
