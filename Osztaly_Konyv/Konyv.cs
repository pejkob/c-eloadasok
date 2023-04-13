﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osztaly_Konyv.Exceptions;

namespace Osztaly_Konyv
{
    public class Konyv
    {
        private string leltariSzam;
        private string isbnSzam;
        private string szerzo;
        private string cim;
        private long _kiadasEv;
        private string nyelv;
        private bool enciklopediae;
        private char eBook;
        private Random rand = new Random();


        public string LeltariSzam
        {
            get => leltariSzam;
            set
            {
                if (value.Length < 11)
                {
                    throw new Exception();
                }
            }
        }

        public string IsbnSzam
        {
            get => isbnSzam;
            set
            {
                if (value.Length != 10 && value.Length != 13)
                {
                    throw new ISBN_NumberLengthException(value.Length);
                }
                switch (value.Length)
                {
                    case 10:

                        //2. tipus
                        /*int szam = 0;
                        int n = 1;
                        for (int i = 0; i < 9; i++)
                        {
                            szam += n * int.Parse(value[i].ToString());
                            n++;
                        }
                        if (szam % 11 != int.Parse(value[9].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }*/


                        //1. tipus
                        int szam3 = 0;
                        int n3 = 10;
                        int oszto = 0;
                        for (int i = 0; i < 9; i++)
                        {
                            if (n3 >= 2 && n3 <= 10)
                            {
                                szam3 += n3 * int.Parse(value[i].ToString());
                                n3--;

                            }
                        }
                        while ((oszto * 11) < szam3)
                        {
                            oszto++;
                        }
                        if ((oszto * 11) - szam3 != int.Parse(value[9].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }
                        break;
                    case 13:
                        int szam2 = 0;
                        int n2;
                        for (int i = 0; i < 12; i++)
                        {
                            if (i % 2 == 0)
                            {
                                n2 = 1;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                            else
                            {
                                n2 = 3;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                        }
                        if (szam2 % 10 != int.Parse(value[12].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }

                        break;
                    default:
                        break;
                }
                isbnSzam = value;

            }
        }

        public string Szerzo
        {
            get => szerzo;
            set {
                if (value.Length < 6)
                {
                    throw new SzerzonemhelyesException();
                }

            }
        }
        public string Cim { get => cim; set => cim = value; }
        public long KiadasEv
        {
            get => _kiadasEv;
            set
            {
                if (value < 10000 && value > 2023)
                {
                    throw new KiadasevenemhelyesException();
                }
            }
        }
        public string Nyelv
        {
            get => nyelv;
            set
            {
                if (value.Length == 0)
                {
                    throw new NyelvnemhelyesException();
                }
            }
        }
        public bool Enciklopediae {
            get => enciklopediae;
            set => enciklopediae = value;}
        public char Ebook { get => eBook; set => eBook = value; }

        public Konyv()
        {

        }

        public Konyv(string leltariSzam, string isbnSzam, string szerzo, string cim, long kiadasEv, string nyelv, bool enciklopediae, char ebook)
        {
            LeltariSzam = leltariSzam;
            IsbnSzam = isbnSzam;
            Szerzo = szerzo;
            Cim = cim;
            KiadasEv = kiadasEv;
            Nyelv = nyelv;
            Enciklopediae = enciklopediae;
            Ebook = ebook;
        }

        ~Konyv()
        {
            Console.WriteLine("DESTRUKTOR CSSSSSSSSSSSSSSS");
        }
    }
}
