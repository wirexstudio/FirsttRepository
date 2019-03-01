using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._10.savrsen__broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());
            int djelitelji = 0;

            for(int i = 1; i < broj; i++)
            {
                if(broj % i == 0)
                {
                    djelitelji += i;
                }
            }

            if(djelitelji == broj)
            {
                Console.WriteLine("Broj je savršen.");
            }
            else
            {
                Console.WriteLine("Broj nije savršen.");
            }
            Console.ReadLine();
        }
    }
}
