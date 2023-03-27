using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bieniek_plecak
{
    public class Backpack
    {

        public int[,] items;
        public int[] taken;
        public int reward = 0;
        public int taken_amount = 0;

        public Backpack(int number)
        {
            items = new int[number, 2];
            taken = new int[number];

        }
  
        public int[,] CreateItems(int number)
        {

            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    items[i, j] = random.Next(1, 10);
                    // Console.WriteLine(items[i, j]);
                }
            }

            return items;
        }
        public int[] TakenItems(int numbers, int weight, int[,] items)
        {

            for (int i = 0; i < numbers; i++)
            {
                if (items[i, 1] > weight)
                {
                    taken[i] = 0;
                }
                else
                {
                    weight = weight - items[i, 1];
                    taken_amount++;
                    reward = reward + items[i, 0];
                    taken[i] = 1;
                }

            }
            Console.WriteLine("Ukradziono " + taken_amount + " przedmiotow, a ich laczna wartosc to: " + reward + " \n");
            Console.WriteLine("Zostalo mi jeszcze " + weight + " miejsca w plecaku\n");
            return taken;


        }

    }
}