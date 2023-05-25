using System;

namespace CSharp
{
    public class exercicio06 
    {
        public static void criativo()
        {
            int tamanho;
            tamanho = Convert.ToInt32(Console.ReadLine());
            double[] linhas = {1,2,3,4,5,6};


   		    for (int x = 0; x < tamanho; x++) 
            {
		    for (int j = 0; j < linhas[x]; j++) 
                {
	        Console.Write("*");
  		  	    }
                Console.WriteLine("");
 		    }
        }
    }
} 