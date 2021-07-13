using System;

namespace ListaAEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1, i2, i3, i4, i5, total;
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("Digite a quantidade comprada de cada produto");

            Console.WriteLine("Hambúrguer R$ 8,00");
            i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Batata frita R$ 12,00");
            i2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Refrigerante R$ 3,00");
            i3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cerveja R$ 5,00");
            i4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Doce R$ 3,00");
            i5 = int.Parse(Console.ReadLine());

            total = (i1 * 8) + (i2 * 12) + (i3 * 3) + (i4 * 5) + (i5 *3);

            Console.WriteLine("O total da compra foi de: R$ {0},00",total);
        }
    }
}
