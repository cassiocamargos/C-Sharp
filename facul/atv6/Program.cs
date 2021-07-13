using System;

namespace atv6
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f = new Funcionarios ("Cássio Camargos","55544433322",0,0,0);

            f.setNome("Cássio Camargos");
            f.setCPF("55544433322");
            f.setCarrosNovos(5);
            f.setCarrosUsados(5);
            f.setValorAcessorio(150);

            Console.WriteLine("Nome {0}, CPF: {1}, Quantidade de carros novos: {2}, Quantidade de carros usados: {3}, Valor do acessório {4}", f.getNome(), f.getCPF(), f.getcarrosNovos(), f.getCarrosUsados(), f.getValorAcessorio());
            Console.WriteLine("Valor do salário: {0}", f.getSalario());
        }
    }
}
