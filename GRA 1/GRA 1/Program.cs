using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA_1
{
    class Program
    {
        static void Main()
        {
            int szukana;
            int liczbaProb = 10;
            int wygrana = 1;

            Random x = new Random();
            szukana = x.Next(1,100);
            //Console.WriteLine(szukana);

            Console.WriteLine("Witaj stara koparo.\n masz {0} prób na znalezienie liczby wylosowanej przez ten program. \n Liczba ta mieści się w zakresie od 1 do 100. \n Powodzenia :)", liczbaProb);

            for (int i = 0; i <liczbaProb; i++)
            {
                Console.WriteLine("\n Pozostało ci prób {0}", liczbaProb-i);



                string liczba =  Console.ReadLine();
                if (String.IsNullOrEmpty(liczba))
                {
                    Console.WriteLine("Ale coś podać musisz.\n I tak zeszła ci jedna próba");
                    
                }
                else
                {
                    var podawana = Int32.Parse(liczba);
                    if (podawana == szukana)
                    {
                        Console.WriteLine("Liczba {0} jest rówana liczbie {1} \n ", podawana, szukana);
                        i = liczbaProb;
                        wygrana = 2;
                    }
                    else if (podawana > szukana)
                    {
                        Console.WriteLine("liczba {0} jest większa od szukanej", podawana);
                    }
                    else if (podawana < szukana)
                    {
                        Console.WriteLine("Liczba {0} jest mniejsza od szukanej", podawana);
                    }
                }

                
            }

            if (wygrana==1)
            {
                Console.WriteLine("\n Przegraleś !!");
            }
            else
             Console.WriteLine("\n Wygraleś !!");




            Console.ReadKey();
        }
       
    }
}
