using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._10.savrsen__broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");

            try
            {
                int broj = int.Parse(Console.ReadLine());
                if(broj <= 0)
                {
                    throw new PozitivanBrojException("UNESITE POZITIVAN BROJ!");
                }

                int djelitelji = 0;

                for (int i = 1; i < broj; i++)
                {
                    if (broj % i == 0)
                    {
                        djelitelji += i;
                    }
                }

                if (djelitelji == broj)
                {
                    Console.WriteLine("Broj je savršen.");
                }
                else
                {
                    Console.WriteLine("Broj nije savršen.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greška. Poruka: {0}", ex.ToString());
            }
            catch(PozitivanBrojException ex)
            {
                Console.WriteLine("Greška. Poruka: {0}", ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }

    public class PozitivanBrojException : Exception
    {
        public PozitivanBrojException()
        {
        }

        public PozitivanBrojException(string message) : base(message)
        {
        }

        public PozitivanBrojException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
