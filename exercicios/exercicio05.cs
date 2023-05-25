using System;

namespace CSharp
{
    public class exercicio05 
    {
        public static void mediah()
        {
            int tam;
            Console.Write("Informe o limite de pessoas: ");
            tam = Convert.ToInt32(Console.ReadLine());
            double[] teste = new double[tam];

            double somas = 0;
            for(int i=0; i< teste.Length; i++){
                Console.Write("Informe uma altura: ");
                teste[i] = Convert.ToDouble(Console.ReadLine());
                somas += teste[i];
            }
            Console.WriteLine($"A média é {somas/teste.Length}");
            for(int i=0; i< teste.Length; i++){
                Console.Write($"{teste[i]}, ");
            }
        }
    }
}