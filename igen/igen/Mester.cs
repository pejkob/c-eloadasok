using System;
namespace igen
{
    enum Köpeny {kapucnis_barna,kapucnis_szürke,lenge_vászon }
    internal class Mester : erohasznalo
    {
        bool tanacsTag;
        int korabbiTanitvanyok;
        Köpeny k;


        public bool TanacsTag
        {
            get { return tanacsTag; }
            private set
            {
                if (!TanacsTag)
                {
                    this.tanacsTag = value;
                }
            
            }
        }

        public Köpeny K
        {
            get
            {
                return k;
            }
        }

        public int KorabbiTanitvanyok { get { return korabbiTanitvanyok; }
            set {
                if (value>=0&&value<=20)
                {
                    korabbiTanitvanyok = value;
                }
                else
                {
                    Console.WriteLine("Hibás érték");
                }

                }
        }

        public Mester(string nev, Random rnd):base(nev,rnd)
        {
            Nev = nev + " Mester";
            int ksz = rnd.Next(3);
            this.k = (Köpeny)ksz;
            int o = rnd.Next(2);
            if (!Oldal) TanacsTag = false;
            else TanacsTag = true;
            korabbiTanitvanyok = rnd.Next(21);

        }

        public void kopenyCsere(Köpeny kopeny)
        {
            this.k = kopeny;
        }

        public Mester(string nev,Random rnd,bool tanacstag,Köpeny k,int korabbitanitvanyok):base(nev,rnd)
        {
            TanacsTag = tanacstag;
            this.k = k;
            KorabbiTanitvanyok = korabbitanitvanyok;
        }
    }
}

