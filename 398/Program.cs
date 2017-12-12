using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _398
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("vuvedete broi dni v meseca: ");
                n = Convert.ToInt32(Console.ReadLine());

            }
            while (n < 1 || n > 31);
            Console.WriteLine("Vuvedete kolichestvoto na valeji za vs den za station A: ");
            double[] A= new double[n] ;
            fillArray(A);
            Console.WriteLine("Vuvedete kolichestvoto na valeji za vs den za station B: ");
            double[] B = new double[n];
            fillArray(B);
            Console.WriteLine("Vuvedete kolichestvoto na valeji za vs den za station C: ");
            double[] C = new double[n];
            fillArray(C);
            Console.WriteLine("Average rain for A: "+srednoaritmetichno(A));
            Console.WriteLine("Average rain for B: " + srednoaritmetichno(B));
            Console.WriteLine("Average rain for C: " + srednoaritmetichno(C));
            Console.WriteLine("Za stanciq A: "); Check(A);
            Console.WriteLine("Za stanciq B: "); Check(B);
            Console.WriteLine("Za stanciq C: "); Check(C);


        }


        static void fillArray(double[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = double.Parse(Console.ReadLine());

            }

        }
        static double srednoaritmetichno(double[] input)
        {
            double average = 0;
            for (int i = 0; i < input.Length; i++)
            {
                average += input[i];
            }
            return average/input.Length;
        }
        static void Check(double[] input)
        {
            Console.WriteLine("Dni s kolichestvo valeji nad srednoto: ");
            double sr = srednoaritmetichno(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > sr) { Console.WriteLine("Den nomer {0}", i + 1); }
            }
        }







    }
}
