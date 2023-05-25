//FUP que leia um número inteiro de 1 a 3 e imprima o tipo de combustível correspondente,sendo 1 - Álcool, 2 - Gasolina, 3 - Diesel, 
//utilizando a estrutura switch case. Implemente umafunção que recebe o número e retorna o tipo de combustível correspondente.

using System;

namespace CSharp
{
    public class Exercicio31
    {
        public static void ex31()
        {
            Console.WriteLine("Digite um número de 1 a 3");
            int numero = Convert.ToInt32(Console.ReadLine());
            string retorno = MinhaFuncao(numero);
            Console.WriteLine(retorno);
        }

        static string MinhaFuncao(int num) {
            switch (num)
            {
                case 1 : {
                    return "Álcool";
                }
                case 2 : {
                    return "Gasolina";
                }
                case 3 : {
                    return "Diesel";
                }
                
                default: {
                    return "Opção inválida";
                }
            }
        }
    }
}