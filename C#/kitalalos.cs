using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Kitalálós 2.0");

            //Nevek bekérése
            Console.WriteLine("Kérem az első játékos nevét!");
            string nev1 = Console.ReadLine();

            Console.WriteLine("Kérem a második játékos nevét!");
            string nev2 = Console.ReadLine();

            int nev1pont;
            int nev2pont;
            int korszam = 0;
            do
            {
                korszam++;
                Console.WriteLine("Körszám: {0}", korszam);
                //Random szám generálása
                Random rnd = new Random();
                int veletlenszam = rnd.Next(1, 1001);
                //Console.WriteLine(veletlenszam);

                //Tippek megadása
                Console.WriteLine("Kérem az első játékos tippjét!");
                int nev1tipp = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kérem a második játékos tippjét!");
                int nev2tipp = Convert.ToInt32(Console.ReadLine());

                //Tippek kiírása

                if (nev1tipp == nev2tipp)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Döntetlen");
                }
                else
                {
                    if (nev1tipp < veletlenszam)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("A(z) {0} játékosnak {1} -el tippelt kevesebbet", nev1, veletlenszam - nev1tipp);
                    }
                    else if (veletlenszam < nev1tipp)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A(z) {0} játékosnak {1} -el tippelt többet", nev1, nev1tipp - veletlenszam);
                    }


                    if (nev2tipp < veletlenszam)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("A(z) {0} játékosnak {1} -el tippelt kevesebbet", nev2, veletlenszam - nev2tipp);
                    }
                    else if (veletlenszam < nev2tipp)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A(z) {0} játékosnak {1} -el tippelt többet", nev2, nev2tipp - veletlenszam);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                int nev1kulonbseg = veletlenszam - nev1tipp;
                int nev2kulonbseg = veletlenszam - nev2tipp;
                 nev1pont = 0;
                 nev2pont = 0;
                if (nev1kulonbseg < nev2kulonbseg)
                {
                    Console.WriteLine("{0} játékos nyert ebben a körben.", nev2);
                    nev2pont++;

                }
                else if (nev2kulonbseg < nev1kulonbseg)
                {
                    Console.WriteLine("{0} játékos nyert ebben a körben.", nev1);
                    nev1pont++;
                }
                else
                {
                    Console.WriteLine("Döntetlen");
                }

                Console.WriteLine("A {0} játékosnak {1} pontja van.", nev1, nev1pont);
                Console.WriteLine("A {0} játékosnak {1} pontja van.", nev2, nev2pont);

            } while (korszam <= 10);

            if (nev1pont < nev2pont)
            { Console.WriteLine("{0} játékos nyert.", nev2); }
            else { Console.WriteLine("{0} játékos nyert.", nev1); }

            Console.ReadKey();
        }
    }
}
