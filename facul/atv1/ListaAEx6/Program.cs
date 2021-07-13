using System;

namespace ListaAEx6
{
    class Program
    {
        static void Main(string[] args)
        {

            int carros, total;

            Console.WriteLine("Salario");
            Console.WriteLine("Escreva a quantia de carros vendidos: ");

            carros = int.Parse(Console.ReadLine());

            total = (carros * 200) + 350;

            Console.WriteLine("Salario total: R$ {0}",total);
        }
    }
}
