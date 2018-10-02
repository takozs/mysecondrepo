using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r= new Random();
            int szam = r.Next(1,1001);
            int szam1 = 0;
            int szam2 = 0;
            int szam3 = 0;
            int szam4 = 0;
            int szam5 = 0;


            Console.WriteLine("Az gép által gondolt szám a(z) {0}. Kissebb(>), nagyobb(<) vagy egyenlő(=) amire ön gondolt?", szam);

            string valasz1 = Console.ReadLine();
            if (valasz1 == "=") Console.WriteLine("Hohó, nagyon ügyes gép vagyok!");
            else if (valasz1 == ">") szam1 = r.Next(1, szam);
            else if (valasz1 == "<") szam1 = r.Next(szam, 1001);


            Console.WriteLine("Akkor erre a számra gondoltam: {0}. Kissebb(<), nagyobb(>) vagy egyenlő(=) amire ön gondolt?", szam1);

             string valasz2 = Console.ReadLine();
            if (valasz2 == "=") Console.WriteLine("Hohó, nagyon ügyes gép vagyok!");
            else if (valasz2 == ">") szam2 = r.Next(szam, szam1);
            else if (valasz2 == "<") szam2 = r.Next(szam1, szam);
            Console.WriteLine(szam2);

            Console.WriteLine("Akkor erre a számra gondoltam: {0}. Kissebb(<), nagyobb(>) vagy egyenlő(=) amire ön gondolt?", szam2);

            string valasz3 = Console.ReadLine();
            if (valasz3 == "=") Console.WriteLine("Hohó, nagyon ügyes gép vagyok!");
            else if (valasz3 == ">") szam3 = r.Next(szam1, szam2);
            else if (valasz3 == "<") szam3 = r.Next(szam2, szam1);
            Console.WriteLine(szam4);

            Console.WriteLine("Akkor erre a számra gondoltam: {0}. Kissebb(<), nagyobb(>) vagy egyenlő(=) amire ön gondolt?", szam3);

            string valasz4 = Console.ReadLine();
            if (valasz4 == "=") Console.WriteLine("Hohó, nagyon ügyes gép vagyok!");
            else if (valasz4 == ">") szam4 = r.Next(szam2, szam3);
            else if (valasz4 == "<") szam4 = r.Next(szam3, szam2);
            Console.WriteLine(szam4);





            Console.ReadKey();
        }
    }
}
