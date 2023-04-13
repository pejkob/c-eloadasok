using System;
namespace Osztaly_Konyv.Exceptions
{
    public class CimnemhelyesException:Exception
    {
        public override string Message => "A címnek legalább 1 karakternek kell lennie";

     
    }
}
