using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            double atlag = 0;
            int[] szamok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Kérem a(z) " + i + ". számot!");
                szamok[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < szamok.Length; i++)
            {
                atlag += szamok[i];
            }
            atlag = atlag / szamok.Length;
            Console.WriteLine("A " + szamok.Length + " darab számnak " + atlag + " az átlaga.");
            Console.ReadKey();

        }
    }
}
