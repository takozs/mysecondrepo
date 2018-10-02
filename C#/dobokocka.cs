using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static int Dobas(int szam)
        {
            Random r = new Random();
            for (int i = 0; i < szam; i++)
            {
                r.Next(1, 7);
                
            }
            return r.Next(1, 7);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Billentyűleütésre dob a gép...");
            Console.ReadKey();

            int gep = Dobas(1);
            Console.WriteLine("A gép {0}-t dobott", gep);

            Console.WriteLine("Billentyűleütésre dob Ön...");
            Console.ReadKey();
            int ember = Dobas(2);
            Console.WriteLine("A USER {0}-t dobott.", ember);

            if (gep == ember) Console.WriteLine("Döntetlen");
            else if (gep > ember) Console.WriteLine("A gép nyert");
            else Console.WriteLine("A USER nyert.");

            Console.ReadKey();

        }
    }
}
