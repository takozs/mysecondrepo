using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int also = 1;
            int felso = 1000;
            char valasz;

            do
            {
                int tipp = (also + felso) / 2;
                Console.WriteLine("A gép által gondolt szám {0}", tipp);
                Console.WriteLine("Jól gondolta a gép? (< , > , =)");
                valasz = Convert.ToChar(Console.ReadLine());
                if (valasz == '=') Console.WriteLine("Ügyes gép vagyok!");
                else if (valasz == '<') felso = tipp - 1;
                else also = tipp + 1;
                Console.WriteLine("alsó érték:{0}, felső érték:{1}", also, felso);
            } while (valasz!= '=');

            Console.ReadKey();

        }
    }
}
