using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExZadochno
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do { Console.WriteLine("Vuvedete dni v meseca");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n<1|| n>31);
            Console.WriteLine("Vuvedete izrabotenite chasove za slujitel 1: ");
            double[] A = new double[n];
            fillArray(A);
            Console.WriteLine("Vuvedete izrabotenite chasove za slujitel 2: ");
            double[] B = new double[n];
            fillArray(B);
            Console.WriteLine("Vuvedete izrabotenite chasove za slujitel 3: ");
            double[] C = new double[n];
            fillArray(C);
            Console.WriteLine("Sredno kol chasove za 1viq: "+ averageHours(A));
            Console.WriteLine("Sredno kol chasove za 2riq: " + averageHours(B));
            Console.WriteLine("Sredno kol chasove za 3tiq: " + averageHours(C));
            Console.WriteLine("Za 1viq rabotesht:"); Check(A);
            Console.WriteLine("Za 2riq rabotesht:"); Check(B);
            Console.WriteLine("Za 3tiq rabotesht:"); Check(C);

        }
        static void fillArray(double []input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
        }

        static double averageHours(double[] input)
        {
            double average = 0;
            for (int i = 0; i < input.Length; i++)
            {
                average += input[i];
            }
            return average / input.Length;
        }
        static void Check(double[] input)
        {
            Console.WriteLine("Dni prez koito se e rabotilo nad srednoto kolichestvo chasove: ");
            double sr = averageHours(input);
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]>sr)
                { Console.WriteLine("Den nomer: {0}  ", i + 1); }
            }
        }
    }
}
