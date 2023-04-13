using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv k = new Konyv();

            /*do
            {

                Console.Write("Add meg az ISBN számot: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string nums = "";
                    foreach (var item in bekert.Split('-'))
                    {
                        nums += item;
                    }
                    k.IsbnSzam = nums;
                    Console.WriteLine("A megadott ISBN kód helyes! A program kilép...");
                    helyes = true;
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!helyes);*/
            bool szerzonemhelyes = true;
            do
            {
                Console.Write("Adja meg a szerzőt! ");
                try
                {
                    string szerzo = Console.ReadLine();
                    if (szerzo!=null&& szerzo.Length < 6)
                    {
                        k.Szerzo = szerzo;
                        szerzonemhelyes = false;
                    } 
                }
                catch (SzerzonemhelyesException e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (szerzonemhelyes);

            bool cimnemhelyes = true;
            do
            {
                Console.Write("Adja meg a címet! ");
                try
                {
                    string cim = Console.ReadLine();
                    if (cim.Length > 1)
                    {
                        k.Cim = cim;
                        cimnemhelyes = false;
                    }
                }
                catch (CimnemhelyesException e)
                {
                    Console.WriteLine(e.Message);
                }
              
            } while (cimnemhelyes);

            bool kiadasEvenemhelyes = true;
            do
            {
                Console.Write("Adja meg a kiadás évét! ");
                try
                {
                    long kiadasEve = long.Parse(Console.ReadLine());
                    k.KiadasEv = kiadasEve;
                    kiadasEvenemhelyes = false;
                }
                catch (KiadasevenemhelyesException e)
                {
                    Console.WriteLine(e.Message);
                }
             
            } while (kiadasEvenemhelyes);

            bool nyelvnemhelyes=true;
            do
            {
                Console.Write("Adja meg a könyv nyelvét! ");
                try
                {
                    string nyelv = Console.ReadLine();
                    k.Nyelv = nyelv;
                    nyelvnemhelyes = false;
                }
                catch (NyelvnemhelyesException e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (nyelvnemhelyes);


            
            bool enciklopediaenemhelyes = true;
            do
            {
                Console.Write("Ez a könyv enciklopédia? ");
                try
                {
                    bool enciklopediae = Convert.ToBoolean(Console.ReadLine());
                    k.Enciklopediae = enciklopediae;
                    enciklopediaenemhelyes = false;
                }
                catch (EnciklopediaenemhelyesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (enciklopediaenemhelyes);

            bool ebooknemhelyes = true;
            do
            {
                Console.WriteLine("A könyvnek van e-book változata? (i/n) ");
                try
                {
                    char ebook = Convert.ToChar(Console.ReadLine());
                    k.Ebook = ebook;
                    ebooknemhelyes = false;
                }
                catch (EbooknemhelyesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            } while (ebooknemhelyes);

            KonyvesPolc konyvesPolc1 = new KonyvesPolc();
            try
            {
                Konyv konyv1 = new Konyv("1","0306406152", "Szerző 1", "Cím 1", 2023, "Magyar", false, 'n');
                Konyv konyv2 = new Konyv("2", "0306406152", "Szerző 1", "Cím 1", 2018, "Magyar", false, 'n');   
                konyvesPolc1.konyvHozzaAdasa(konyv1);
                konyvesPolc1.konyvHozzaAdasa(konyv2);
            }
            catch (ISBN_NumberLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ISBN_NumberFormatException e) 
            {
                Console.WriteLine(e.Message);
            }
            int db = konyvesPolc1.konyvekSzama;
            Console.WriteLine(db);
            Console.WriteLine(konyvesPolc1.konyvekSzama);
            Console.WriteLine(konyvesPolc1.konyvekSzamaFuggveny());
            Console.ReadKey();
        }
    }
}
