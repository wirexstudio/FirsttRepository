using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._13.min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int broj;

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Unesite {0}. broj: ", i.ToString());
                    broj = int.Parse(Console.ReadLine());
                    if(broj <= 0)
                    {
                        throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                    }
                    if (broj > max)
                    {
                        max = broj;
                    }
                    if (broj < min)
                    {
                        min = broj;
                    }
                }
                Console.Write("Najmanji broj je: {0} \nNajveći broj je: {1}", min, max);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Greška. Poruka: {0}", ex.ToString());
            }
            catch (PrirodanBrojException ex)
            {
                Console.WriteLine("Greška. Poruka: {0}", ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

public class PrirodanBrojException : Exception
{
    public PrirodanBrojException()
    {
    }

    public PrirodanBrojException(string message) : base(message)
    {
    }

    public PrirodanBrojException(string message, Exception innerException) : base(message, innerException)
    {
    }

}
