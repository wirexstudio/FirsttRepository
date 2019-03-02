using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._19.suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            try
            {
                int broj = -1;
                while (broj != 0)
                {
                    Console.WriteLine("Unesite prirodan broj: ");
                    broj = int.Parse(Console.ReadLine());
                    if (broj < 0)
                    {
                        throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                    }
                    suma += broj;
                }
                Console.WriteLine("Suma svih unesenih brojeva je: {0}.", suma.ToString());
            }
            catch (PrirodanBrojException ex)
            {
                Console.WriteLine("Greška. Poruka: {0}", ex.ToString());
            }
            catch (FormatException ex)
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
