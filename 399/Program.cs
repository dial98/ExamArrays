using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _399
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Vuvedete valejite za vseki den v meseca v litri na kv.metur: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 1 || n > 31);
            Console.WriteLine("Vuvedete valeji za station A:");
            double[] A = new double[n];
            fillArray(A);
            Console.WriteLine("Vuvedete valeji za station B:");
            double[] B = new double[n];
            fillArray(B);
            Console.WriteLine("Vuvedete valeji za station C:");
            double[] C = new double[n];
            fillArray(C);
            Console.WriteLine("Za station A"); noRain(A);
            Console.WriteLine("Za station B"); noRain(B);
            Console.WriteLine("Za station C"); noRain(C);


        }
        static void fillArray(double[] input)
          {
            for (int i = 0; i < input.Length; i++)
            {
                input[i]=double.Parse(Console.ReadLine());
            }
          }

        static void noRain (double[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0) { Console.WriteLine("Den nomer {0}  ne e valqlo", i +1 ); }
            }
        }












    }
}
