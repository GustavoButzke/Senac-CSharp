using System;

namespace CSharp
{
    public class soma
    {
      public static void somando()
      {
        Console.WriteLine("Informe o primeiro numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 + num2);

      }
    }
}