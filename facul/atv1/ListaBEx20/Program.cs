using System;

namespace ListaBEx20
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            char sexo;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade <= 12){
                Console.WriteLine("Classificação: Criança");
            }else if(idade > 12 && idade < 18){
                Console.WriteLine("Classificação: Adolecente");
            }else{        
                Console.WriteLine("Digite seu sexo: F para Feminino e M para Masculino");
                sexo = char.Parse(Console.ReadLine());
            
                if(idade >= 18 && sexo == 'M' || sexo == 'm'){
                    Console.WriteLine("Classificação: Homem");
                }else if(sexo == 'F' || sexo == 'f'){
                    Console.WriteLine("Classificação: Mulher");
                }
            }
        }
    }
}
