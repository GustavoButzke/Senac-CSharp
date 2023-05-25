using System;

namespace CSharp
{
    public class exercicio01
    {
      public static void temperatura()
      {
        Console.WriteLine("Exercício 04");
        Console.WriteLine("Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit");
        Console.WriteLine("Insira a temperatura em Graus Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (9*celsius+150)/5;
        Console.WriteLine("A temperatura em Fahrenheit é:" + fahrenheit);

      }
    }
}