using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterPancakes
{
    class Program
    {
        static void Main(string[] args)
        {

            string candidate = Console.ReadLine();

            string[] split = candidate.Split(' ');

            string name = split[0];
            int weight = int.Parse(split[1]);
            int height = CalculateHeight(name);

            if (EnergyAtImpact(weight, height) < 1500000)
            {
                Console.WriteLine("The candidate is approved!");
            }

            else
            {
                Console.WriteLine("The candidate is a \"Jupiter pancake\"!");
            }
        }


        static int CalculateHeight(string name)
        {
            int height = 0;

            for (int i = 0; i < name.Length; i++)
            {
                height += (int)name[i];
            }

            return height;
        }

        static double EnergyAtImpact(double weight, int height)
        {
            double energy = weight * height * 24.79;
            return energy;


        }
    }
}
