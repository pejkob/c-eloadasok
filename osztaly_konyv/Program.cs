using System;

namespace osztaly_konyv
{

    class Program
    {
        static Random rnd = new Random();

        public  static void Adatbekeres()
        {
            string isbnKod="";
            int nyelv = 0;
            int szerzo = 0;
            string megjelenes = "";
            bool enciklopedia = false;
            char ebook = 'n';

            Console.WriteLine("Adja meg az ISBN kódot!");
            isbnKod = Console.ReadLine();

            do
            {
             Console.Write("Adja meg a nyelv területi kódját! ");
                    
                   
            } while (!int.TryParse(Console.ReadLine(), out nyelv));

            Console.Write("Megjelenés dátuma: ");
            megjelenes = Console.ReadLine();
            do
            {
             Console.Write("Adja meg a szerző kódját! ");


            } while (!int.TryParse(Console.ReadLine(), out szerzo));

            do
            {
                Console.WriteLine("A könyv enciklopédia? (true/false)");
            } while (!bool.TryParse(Console.ReadLine(),out enciklopedia));

            do
            {
                Console.WriteLine("Van a könyvnek e-book változata? (i/n)");
            } while (!char.TryParse(Console.ReadLine(),out ebook));
           
            AdatAtadas( isbnKod ,nyelv,szerzo,megjelenes,enciklopedia,ebook);


        }

        static void AdatAtadas(string isbn ,int nyelv,int szerzo,string megjelenes,bool enciklopedia, char ebook)
        {
            const string isbnprefix = "979";
            bool looptrue = true;
        while (looptrue)
                {
            try
            {
               

               
                int termekKod = 75;
                int ellenorzoKarakter =0;
                int seged = 0;
                for (int i = 0; i < 10; i++)
                {
                        ellenorzoKarakter += (int)isbn[i] * seged;
                        seged++;
                    
                }
                ellenorzoKarakter = ellenorzoKarakter % 10;
                string isbnSzam = isbnprefix.ToString()+ nyelv.ToString() + szerzo.ToString()+ termekKod.ToString()+ellenorzoKarakter.ToString();
                Console.WriteLine(ellenorzoKarakter);
                Console.WriteLine(isbnSzam);
                if (Convert.ToString(isbnSzam)==isbn)
                {
                    Book newbook = new Book(isbn, szerzo, nyelv, megjelenes, enciklopedia, ebook);
                    Console.WriteLine("Új könyv hozzáadva");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();  
                    looptrue = false;
                }
                else
                {
                    throw new newexception();
                }
                 

                    Console.ReadKey();
            }
           
            catch (newexception e)
            {
                Console.WriteLine(e.Message);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }


        }
        static void Main(string[] args)
        {

            
            Adatbekeres();


           

           

        }
    }
}
