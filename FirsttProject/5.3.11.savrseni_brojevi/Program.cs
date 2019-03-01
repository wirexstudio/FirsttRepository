using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._11.savrseni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Savršeni brojevi iz intervala [1, 1000] su: ");
            int djelitelji;
            for (int i = 1; i <= 1000; i++)
            {
                djelitelji = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        djelitelji += j;
                    }  
                }
                if (djelitelji == i)
                {
                    Console.Write("{0}, ", i.ToString());
                }

            }
            Console.ReadLine();
        }
    }
}
