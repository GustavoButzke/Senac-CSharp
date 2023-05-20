using System;

namespace CSharp
{
    public class exrecicio05
    {
      public static void mediah()
      {
        Console.WriteLine("insira a qtd de pessoas: ");
        double limite[] = new double[];
        float alturas[limite];
        
        for(i=0;i < limite;i++){
            Console.WriteLine("\n Informe a "<<i+1<<"ª altura\n");
            cin>>alturas[i];
            totalAltura += alturas[i];
        }
        media = totalAltura / limite;
        Console.WriteLine($"\nA média é {media}");

       }

    }
}




