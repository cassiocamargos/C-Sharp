using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("nome", 7865, 0.0f);
            Console.WriteLine("O nome do titular é {0}", conta.getTitular());
            Console.WriteLine("O numero é: {0}", conta.getNumero());
            Console.WriteLine("O seu saldo é de: {0}", conta.getSaldo());
            
            conta.setDepositar(100);
           
            Console.WriteLine("Deposito de  reais. O seu saldo é de: {0}", conta.getSaldo());
           
            conta.setSaque(100);          
            Console.WriteLine("Saque de 100 reais. O seu saldo é de: {0}", conta.
            getSaldo());
        }
    }
}
