using System;

namespace CSharp
{
    public class exercicio02
    {
      public static void calculadora()
      {
        Console.WriteLine("Exercício 11");
        Console.WriteLine("Informe o numero do tipo de operação que deseja fazer, sendo:");
        Console.WriteLine("[1] Para Adição");
        Console.WriteLine("[2] Para Subtração");
        Console.WriteLine("[3] Para Multiplicação");
        Console.WriteLine("[4] Para Divisão");
        int op = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o primeiro número que deseja calcular: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o segundo número que deseja calcular: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        if(op == 1){
           Console.WriteLine($"A soma entre {num1} e {num2} é {(num1 + num2)} ");
        }else if(op == 2){
            Console.WriteLine($"A Subtração entre {num1} e {num2} é {(num1 - num2)}");
        }else if(op == 3){
            Console.WriteLine($"A Multiplicação entre {num1} e {num2} é {(num1*num2)}");
        }else if(op == 4){
            Console.WriteLine($"A Divisão entre {num1} e {num2} é {(num1/num2)} ");
        }else{
           Console.WriteLine("Comando Inválido");
        }

      }
    }
}