using System;
namespace osztaly_konyv
{
    public class newexception:Exception
    {
        public newexception()
        {
            Console.WriteLine("Hibás ISBN kód!");
            Program.Adatbekeres();
        }
    }
}
