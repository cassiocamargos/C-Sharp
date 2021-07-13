using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Hello World!");
            }

            Console.WriteLine();

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
                Console.WriteLine(i);
            }    

            Console.WriteLine();

            int c = 0;
            while (c <= 5) 
            {
                Console.WriteLine(c);
                c++;
                if (c == 4) 
                {
                    break;
                }
            }
            
            Console.WriteLine();

            int x = 0;
            while (x <= 5) 
            {
                if (x == 4) 
                {
                    x++;
                    continue;
                }
                Console.WriteLine(x);
                x++;
            }

        }
    }
}
