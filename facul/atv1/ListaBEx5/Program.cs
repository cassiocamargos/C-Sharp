using System;

namespace ListaBEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            float metros, pes;

            Console.WriteLine("Escreva um valor em metros: ");
            metros = float.Parse(Console.ReadLine());

            if(metros < 0){
                Console.WriteLine("Valor invalido");
            }else{
                pes = metros * 3315;

                Console.WriteLine("Valor convertido para pés: {0} pés", pes);
            }
        }
    }
}
