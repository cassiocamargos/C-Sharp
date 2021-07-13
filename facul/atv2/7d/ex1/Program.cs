using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros;
           numeros = new int [10];
           int c;
           int menor=0;

           for(c=0; c<10; c++)
           {
                Console.Write("Entre com o número {0}: ", c+1);
                numeros [c] = int.Parse(Console.ReadLine());

           }
           
            for(c=0; c<numeros; c++)
            {
                if (numeros[c]<menor || c==0)
                {
                    menor = numeros[c];
                }
            }

                Console.WriteLine("O menor valor informado foi: {0}", menor);

        }
        }
    }

