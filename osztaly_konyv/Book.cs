using System;
namespace osztaly_konyv
{
    public class Book
    {
        string isbnSzam;
        int szerzo_k;
        string megjelenesDatuma;
        int nyelv;
        bool enciklopedia;
        char ebook; //i van n nincs

        public string IsbnSzam
        {
            get { return isbnSzam; }
            set { isbnSzam = value; }
        }
        public int Szerzo_k
        {
            get
            {
                return szerzo_k;
            }
            set { szerzo_k = value; }
        }
        public string MegjelenesDatuma
        {
            get { return megjelenesDatuma; }
            set { megjelenesDatuma = value; }

        }
        public int Nyelv {
            get { return nyelv; }
            set { nyelv = value; }
        }
        public bool Enciklopedia
        {
            get { return enciklopedia; }
            set { enciklopedia = value; }
        }
        public char Ebook
        {
            get { return ebook; }
            set
            {
                ebook = value;
            }
        }
        public Book(string isbnSzam, int szerzo_k, int nyelv, string megjelenesDatuma, bool enciklopedia, char ebook)
        {
            this.isbnSzam = isbnSzam;
            this.szerzo_k = szerzo_k;
            this.nyelv = nyelv;
            this.megjelenesDatuma = megjelenesDatuma;
            this.enciklopedia = enciklopedia;
            this.ebook = ebook;
        }

        public Book()
        {
        }

        ~Book()
        {
            Console.WriteLine("Destruktor aktiválva");
        }
    }
}
