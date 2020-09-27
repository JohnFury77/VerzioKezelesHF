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
            Console.WriteLine("Adja meg mennyi számot szeretne megadni!");
            int mennyi = int.Parse(Console.ReadLine());
            int[] szamok = new int[mennyi];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Kérem a(z) " + (i + 1) + ". számot!");
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
