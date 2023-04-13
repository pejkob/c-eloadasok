using System;
namespace Osztaly_Konyv.Exceptions
{
    public class EbooknemhelyesException:Exception
    {
        public override string Message => "i vagy n az elvárt karakter";

    }
}
