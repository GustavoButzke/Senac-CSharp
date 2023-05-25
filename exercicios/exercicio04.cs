using System;

namespace CSharp
{
    public class exercicio04
    {
      public static void batata()
      {
		Console.WriteLine("\n Enquanto digitar 1 aparecerá 'batata'");
        int num23;
		do{
		    num23 = Convert.ToInt32(Console.ReadLine());
		if (num23 == 1){
            Console.WriteLine("\n Batata !");
		}
		}	while(num23==1);	

      }
    }
}








