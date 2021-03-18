using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhas;
            double km = 1.609;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------");
            Console.WriteLine("Milhas Para Km");
            Console.WriteLine("--------------");
            Console.ResetColor();

            Console.WriteLine();
            Console.Write("Digite seu valor em milhas: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            milhas = double.Parse (Console.ReadLine());
            Console.ResetColor();
            Console.Write("\n");

            Console.Write("Seu valor de milhas para Km: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{milhas * km}");
            Console.ResetColor();
            Console.Write("\n");

        }
    }
}
