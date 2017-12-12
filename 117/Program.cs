using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i=1; i<=2; i++)
            {
                Console.WriteLine("Vuvedete cqlo chislo");
                int x = int.Parse(Console.ReadLine());
                if (x == 0) { break; }
                if (x % 2==0)
                { 
                        continue;
                        x+=x; }
                Console.WriteLine("Mejdinen result  " +num);

            }
            Console.WriteLine("Proizv. na chetnite e "+ num);
        }

    }
}
