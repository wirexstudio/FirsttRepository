using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._21.zavrsni_uspjeh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj predmeta za ocjenjivanje: ");
            try
            {
                int brojPredmeta = int.Parse(Console.ReadLine());
                if(brojPredmeta <= 0)
                {
                    throw new PozitivanBrojException("UNESITE POZITIVAN BROJ!");
                }
                int sumaOcjena = 0;
                string ocjena = "";
                bool uspjehNedovoljan = false;

                for (int i = 1; i <= brojPredmeta; i++)
                {
                    bool unosObavljen = false;
                    while (!unosObavljen)
                    {
                        Console.WriteLine("Unesite ocjenu {0}. predmeta", i);
                        ocjena = Console.ReadLine();
                        if (ocjena == "1" || ocjena == "2" || ocjena == "3" || ocjena == "4" || ocjena == "5")
                        {
                            unosObavljen = true;
                        }
                        else
                        {
                            Console.WriteLine("Pogrešan unos!");
                        }

                    }

                    if (ocjena == "1")
                    {
                        uspjehNedovoljan = true;
                        break;
                    }
                    else
                    {
                        sumaOcjena += int.Parse(ocjena);
                    }
                }
                if (uspjehNedovoljan)
                {
                    Console.WriteLine("Uspjeh je nedovoljan!");
                }
                else
                {
                    Console.WriteLine("Prosjek je {0}.", (double)sumaOcjena / brojPredmeta);
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

