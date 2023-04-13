using System;
namespace Osztaly_Konyv.Exceptions
{
    public class KiadasevenemhelyesException:Exception
    {
        public override string Message => "A kiadás évének -10000 és 2023 között kell lennie";

    }
}
