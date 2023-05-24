//FUP que leia um número inteiro de 1 a 3 e imprima o tipo de combustível correspondente,sendo 1 - Álcool, 2 - Gasolina, 3 - Diesel, 
//utilizando a estrutura switch case. Implemente umafunção que recebe o número e retorna o tipo de combustível correspondente.

using System;

namespace CSharp
{
    public class exercicio35
    {
      public static void ex35()
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