using System;

namespace metodo2
{
    class Program
    {
        static void MyMethod(string fname, int age) 
        {
            Console.WriteLine($"{fname} is {age} years old");
        }

        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }
    }
}
