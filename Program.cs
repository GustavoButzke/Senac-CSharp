﻿using System;

namespace CSharp
{
    public class Program
    {
      static void Main(string[] args)
      {
        int op;
        do{
            Console.WriteLine("\n \t Selecione um exercício da Lista: \n");
            Console.WriteLine("\n [1] Exercício 1");
            Console.WriteLine("\n [2] Exercício 2");
            Console.WriteLine("\n [3] Exercício 3");
            Console.WriteLine("\n [4] Exercício 4");
            Console.WriteLine("\n [5] Exercício 5");
            Console.WriteLine("\n [6] Use a sua criatividade");
			Console.WriteLine("\n [31] Exercicio 31");
			Console.WriteLine("\n [99] Desafio Prova");
            Console.WriteLine("\n [0] Encerrar \n");
            op = Convert.ToInt32(Console.ReadLine());

            	switch(op) {
			case 1: {
                exercicio01.temperatura();
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
                exercicio04.batata();
				break;
			};
			case 5: {
				exercicio05.mediah();
				break;
			};
			case 31: {
				Exercicio31.ex31();
				break;
			};
			case 99: {
				Console.WriteLine("Sendo criativo");
				exercicio06.criativo();
				break;
			};
			case 0: {
				Console.WriteLine("Finalizando");
				break;
			};
			default: {
				Console.WriteLine("\nOpção inválida");
				break;
			}
		}
	} while(op != 0);
	Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
        }
    }
}