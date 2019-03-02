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
            Console.Write("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            
            while(broj > 0)
            {
                suma += broj;
                Console.WriteLine("Unesite sljedeći broj: ");
                broj = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma svih unesenih brojeva je: {0}", suma);
            Console.ReadLine();
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
