using System;
namespace igen
{
    enum kardszine { piros, zöld, kék, lila, sárga }

    internal class erohasznalo
	{
		string nev;
		int midiklorianok;
		kardszine kSzin;
		bool oldal;

		public string Nev
		{
			get { return nev; }
			protected set
			{
				if (value.Length>=3)
				{
					nev = value;
				}
				else
				{
					throw new Exception("A név túl rövid!");
				}
			}

		}

		public int Midikolrianok
		{
			get { return midiklorianok; }
			set
			{
				if (value>=3000&&value<2000)
				{
					midiklorianok = value;
				}
				else
				{
					throw new Exception("Nem vagy Jedi!");
				}
			}
		}

		 public kardszine KSzine
		{
			get { return kSzin; }
		}

		byte counter=0;
		public bool Oldal
		{
			get { return oldal; }
			set
			{
                if (this.counter<2)
				{
				    oldal = !oldal;
                    counter++;
                }
                else
				{
					throw new Exception("Hiba");
				}
			}
		}

		public erohasznalo(string nev,Random rnd)
        {
            this.nev = nev;
			this.midiklorianok = rnd.Next(3000, 20000);
			int oldalRnd = rnd.Next(0, 5);
			if (oldalRnd==1)
			{
				this.oldal = false;
            }
			else { this.oldal = true; }

			if (this.oldal==false)
			{
				this.kSzin = kardszine.piros;
			}
			else
			{
				kSzin = (kardszine)oldalRnd;
				oldal = true;
			}
        }

		

        public override string ToString()
        {
            return $"{nev} {midiklorianok} {(oldal?"Köztársaság":"Szeparatisták")} {kSzin}";
        }
    }
}

