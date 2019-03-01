using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._9.djeljitelji
{

    //class NeprirodanBroj : Exception
    //{
    //    public NeprirodanBroj(string poruka)
    //    {
            
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");

            try
            {
                int broj = int.Parse(Console.ReadLine());
                if( broj <= 0)
                {
                    throw new NeprirodanBrojException("UNESITE PRIRODAN BROJ!");
                }


                Console.WriteLine("Djelitelji broja {0} su: ", broj);

                for (int i = 1; i <= broj; i++)
                {
                    if (broj % i == 0)
                    {
                        Console.Write("{0}, ", i.ToString());
                    }
                }

            }
            catch (NeprirodanBrojException ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }

    public class NeprirodanBrojException : Exception
    {
        public NeprirodanBrojException()
        {
        }

        public NeprirodanBrojException(string message) : base(message)
        {
        }

        public NeprirodanBrojException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
