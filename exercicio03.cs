using System;

namespace CSharp
{
    public class exrecicio03
    {
      public static void criminoso()
      {
            Console.WriteLine($"Trocou mensagens com a vítima? \n[0] Não\n[1] Sim ");
            int mens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Esteve no local do crime? \n[0] Não\n[1] Sim ");
            int local = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"É parente ou reside perto da vítima? \n[0] Não\n[1] Sim ");
            int parente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Devia algum valor para a vítima? \n[0] Não\n[1] Sim ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Trabalha ou trabalhou com a vítima? \n[0] Não\n[1] Sim ");
            int trabalho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Possui algum tipo de relacionamento amoroso com a vítima? \n[0] Não\n[1] Sim ");
            int relacionamento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ficou feliz pelo destino fatídico na vítima? \n[0] Não\n[1] Sim");
            int sentimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Possui algum tipo de arma de fogo? \n[0] Não\n[1] Sim ");
            int arma = Convert.ToInt32(Console.ReadLine());

            int resposta = mens + local + parente + valor + trabalho + relacionamento + sentimento + arma;


            if(resposta == 4){
                Console.WriteLine($"\n\t Suspeito do Crime !!");
            }else if(resposta == 8){
                Console.WriteLine($"Assassino !!");
            }else if(resposta >= 5 && resposta <= 7){
                Console.WriteLine($"Possível Criminoso !!");
            }else if(resposta < 4){
                Console.WriteLine($"Inocente !!");
            }else{
                Console.WriteLine($"Resposta Inválida !!");
            }

      }
    }
}