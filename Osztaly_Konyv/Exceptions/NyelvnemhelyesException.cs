using System;
namespace Osztaly_Konyv.Exceptions
{
    public class NyelvnemhelyesException:Exception
    {
        public override string Message => ("A nyelv mező nem lehet üres");
    }
}
