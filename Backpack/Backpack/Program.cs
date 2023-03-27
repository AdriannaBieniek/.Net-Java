using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bieniek_plecak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj maksymalny udzwig i ilosc przedmiotow\n");
            string? w = Console.ReadLine();
            int weight = Convert.ToInt32(w);
            string? a = Console.ReadLine();
            int amount = Convert.ToInt32(a);

            if (amount < 0)
            {
                Console.WriteLine("Liczba przedmiotow musi byc wieksza niz 0!\n");
                Thread.Sleep(3000);
                return;
            }
            Backpack backpack = new Backpack(amount);

            int[,] test = backpack.CreateItems(amount);
            int[] test2 = backpack.TakenItems(amount, weight, test);
            Console.WriteLine("Wartosc \t Waga\t Biore (1-tak)\t");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(test[i, 0] + "\t\t" + test[i, 1] + "\t\t" + test2[i] + "\n");

            }
            Console.ReadLine();
        }

    }
}