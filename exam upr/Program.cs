using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_upr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int text = Text();
            Console.WriteLine("texta v chislo e :{0}", Text());
        }
        public static int Text()
        {
            Console.WriteLine("Enter your text here:");
            string text = Console.ReadLine();
            int number = 0;
            foreach (char letter in text)
            {
                number += (int)letter;
            }
            return number;
        }
    }
}

        
    
