using System;
namespace Osztaly_Konyv.Exceptions
{
	public class SzerzonemhelyesException:Exception
	{
        public override string Message => "A szerző nem megfelelő!";
    }
}

