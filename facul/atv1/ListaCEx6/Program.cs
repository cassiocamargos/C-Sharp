using System;

namespace ListaCEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, qtd;
            float soma, media, nota;

            soma=0;
            c = 0;

            Console.Write("Digite a quantidade de alunos na sala para a media das notas: ");
            qtd = int.Parse(Console.ReadLine());

            while(c<qtd){
                Console.Write("Digite a nota: ");
                nota = float.Parse(Console.ReadLine());
                if(nota<0){
                    break;
                }
                c = c + 1;
                soma = soma + nota;
            }

            media = soma / qtd;

            Console.Write("A media da sala é: {0}", media);
        }
    }
}
