//FUP que leia um número inteiro de 1 a 3 e imprima o tipo de combustível correspondente,sendo 1 - Álcool, 2 - Gasolina, 3 - Diesel, 
//utilizando a estrutura switch case. Implemente umafunção que recebe o número e retorna o tipo de combustível correspondente.

using System;

namespace CSharp
{
    public class exercicio31
    {
      public static void ex31(string[] args)
      {
        int op;
        do{
            Console.WriteLine("\n \t Escolha um numero de 1 a 3 para selecionar o tipo de combustível: \n");
            int numero = Convert.ToInt32(Console.ReadLine());
    
            Console.WriteLine("\n [1] Álcool");
            Console.WriteLine("\n [2] Gasolina");
            Console.WriteLine("\n [3] Diesel");
            Console.WriteLine("\n [7] Encerrar \n");
            op = Convert.ToInt32(Console.ReadLine());

            	switch(op) {
			case 1: {
                Console.WriteLine("\n \t tste \n");
				break;
			};
			case 2: {
                exercicio02.calculadora();
                break;      
			};
			case 3: {
                exrecicio03.criminoso();
				break;
			};
			case 4: {
				Console.WriteLine("Finalizando");
				break;
			};
			default: {
				Console.WriteLine("\nOpção inválida");
				break;
			}
		}
	} while(op != 7);
	Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
        }


    }
}