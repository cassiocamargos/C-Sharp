using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno ("Cássio", "N6567B6", 50, 9);

            Console.WriteLine(A.isAprovado());
            Console.WriteLine(A.ToString());
        }
    }
}
