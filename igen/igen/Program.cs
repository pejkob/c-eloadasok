using System;

namespace igen
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            erohasznalo erohasznalo = new erohasznalo("XD",rnd);
            Console.WriteLine(erohasznalo);

            Mester mester1 = new Mester("Fekete",rnd);
            Console.WriteLine(mester1.Nev);
            Console.WriteLine(mester1.K);
            Mester mester2 = new Mester("Fehér", rnd, true, Köpeny.kapucnis_barna, 2);
            Console.WriteLine(mester2.Nev);
            Console.WriteLine(mester2.TanacsTag);
            Console.ReadKey();
        }
    }
}

