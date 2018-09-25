using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 1000;
            string valasz;
            Random r = new Random();

            do
            {
                int gondoltszam = r.Next(MIN, MAX + 1);
                int tipp = 1;
                int tippszam = 0;
                Console.ForegroundColor = ConsoleColor.Gray;
                do
                {
                    tippszam++;
                    Console.WriteLine("Gondoltam egy számot {0} és {1} között. Találd ki! ", MIN, MAX);
                    Console.WriteLine("A gép által gondolt szám: {0} ", gondoltszam);
                    tipp = Convert.ToInt32(Console.ReadLine());
                    if (gondoltszam > tipp) Console.WriteLine("Rosszul tippeltél, nagyobb számra gondoltam!");
                    else if (gondoltszam < tipp) Console.WriteLine("Rosszul tippeltél, kissebb gondoltam!");
                }
                while (tipp != gondoltszam);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A fene a jó dolgodat hogy {0}-ra eltalaltad!", tippszam);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Szeretnél új játékot játszani? (i/n)"); 
                valasz = Console.ReadLine();
                Console.Clear();
            } while (valasz == "i");
            Console.WriteLine("Jó játék volt!");
             
             
                

            Console.ReadKey();
        }
    }
}
