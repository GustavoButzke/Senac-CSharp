using System;

namespace CSharp
{
    public class Program
    {
      static void Main(string[] args)
      {
 //       Console.WriteLine("Informe o primeiro numero: ");
 //       num1 = Convert.ToInt32(Console.ReadLine());
 //       Console.WriteLine("Informe o segundo numero: ");
 //       num2 = Convert.ToInt32(Console.ReadLine());
 //       Console.WriteLine(num1 + num2);

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
 //      Console.WriteLine("[4] Para Divisão");
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