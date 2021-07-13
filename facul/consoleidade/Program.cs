using System;

namespace consoleidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_atual, ano_nasc, idade;
            
            //printf("entre com o ano atual");
            Console.WriteLine("Entre com o ano atual: ");
            
            //scanf("%i",&ano_atual);
            ano_atual = int.Parse(Console.ReadLine());

            //printf("entre com o ano atual");
            Console.WriteLine("Entre com o ano de nascimento: ");
            
            //scanf("%i",&ano_atual);
            ano_nasc = int.Parse(Console.ReadLine());

            idade = ano_atual- ano_nasc;

            Console.WriteLine("a idade é {0} anos",idade);

        }
    }
}
