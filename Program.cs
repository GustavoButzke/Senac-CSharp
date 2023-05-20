using System;

namespace CSharp
{
    public class Program
    {
      static void Main(string[] args)
      {
        int op;
        do{
            Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
            Console.WriteLine("\n [1] Exercício 1");
            Console.WriteLine("\n [2] Exercício 2");
            Console.WriteLine("\n [3] Exercício 3");
            Console.WriteLine("\n [4] Exercício 4");
            Console.WriteLine("\n [5] Exercício 5");
            Console.WriteLine("\n [6] Use a sua criatividade");
            Console.WriteLine("\n [7] Encerrar \n");
            op = Convert.ToInt32(Console.ReadLine());

            	switch(op) {
			case 1: {
                soma.somando();
				break;
			};
			case 2: {
				break;
			};
			case 3: {
				break;
			};
			case 4: {
				break;
			};
			case 5: {
				break;
			};
			case 6: {
				Console.WriteLine("Sendo criativo");
				break;
			};
			case 7: {
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

        

 //       Console.WriteLine("Exercício 04");
 //       Console.WriteLine("Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit");
 //       Console.WriteLine("Insira a temperatura em Graus Celsius:");
 //       double celsius = Convert.ToDouble(Console.ReadLine());
 //       double fahrenheit = (9*celsius+150)/5;
 //       Console.WriteLine("A temperatura em Fahrenheit é:" + fahrenheit);

 //       Console.WriteLine("Exercício 11");
 //       Console.WriteLine("Informe o numero do tipo de operação que deseja fazer, sendo:");
 //       Console.WriteLine("[1] Para Adição");
 //       Console.WriteLine("[2] Para Subtração");
 //       Console.WriteLine("[3] Para Multiplicação");
 //       Console.WriteLine("[4] Para Divisão");
 //       int op = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Informe o primeiro número que deseja calcular: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Informe o segundo número que deseja calcular: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());

//        if(op == 1){
//           Console.WriteLine($"A soma entre {num1} e {num2} é {(num1 + num2)} ");
//        }else if(op == 2){
//            Console.WriteLine($"A Subtração entre {num1} e {num2} é {(num1 - num2)}");
//        }else if(op == 3){
//            Console.WriteLine($"A Multiplicação entre {num1} e {num2} é {(num1*num2)}");
//        }else if(op == 4){
//            Console.WriteLine($"A Divisão entre {num1} e {num2} é {(num1/num2)} ");
//        }else{
//           Console.WriteLine("Comando Inválido");
//        }

        }
    }