using System;

namespace PJfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrador admini = new Administrador ("Joao", "Rua. YYY", "12 1478-6589", 212, 1764.30, 0.12, 80.50);
            Operario oper  = new Operario ("Joao", "Rua. YYY", "12 1478-6589", 212, 1500.00, 0.1, 150.90, 0.15);
            Vendedor vende = new Vendedor ("Maria", "Rua. XYXY", "12 3214-8596", 321, 1750.32,0.1,250.55,0.15);
            Fornecedor fornec = new Fornecedor ("Mario", "Rua. ZZZ", "12 5632-4523", 20700.00, 7500.00);
            Console.Write("Nome: ");
            Console.WriteLine(admini.getNome());
            Console.Write("End: ");
            Console.WriteLine(admini.getEndereco());
            Console.Write("Tel: ");
            Console.WriteLine(admini.getTelefone());
            Console.Write("Codigo setor: ");
            Console.WriteLine(admini.getCodigoSetor());
            Console.Write("Salario Base: ");
            Console.WriteLine(admini.getSalarioBase());
            Console.Write("Impostos: ");
            Console.WriteLine(admini.getImposto());
            Console.Write("Ajuda de custo: ");
            Console.WriteLine(admini.getAjudaDeCusto());
            Console.Write("Salario: {0}", admini.calcularSalario());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Nome: ");
            Console.WriteLine(oper.getNome());
            Console.Write("End: ");
            Console.WriteLine(oper.getEndereco());
            Console.Write("Tel: ");
            Console.WriteLine(oper.getTelefone());
            Console.Write("Codigo setor: ");
            Console.WriteLine(oper.getCodigoSetor());
            Console.Write("Salario Base: ");
            Console.WriteLine(oper.getSalarioBase());
            Console.Write("Impostos: ");
            Console.WriteLine(oper.getImposto());
            Console.Write("Valor Produção: ");
            Console.WriteLine(oper.getValorProducao());
            Console.Write("Comissão: ");
            Console.WriteLine(oper.getComissao());
            Console.Write("Salario: {0}", oper.calcularSalario());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Nome: ");
            Console.WriteLine(vende.getNome());
            Console.Write("End: ");
            Console.WriteLine(vende.getEndereco());
            Console.Write("Tel: ");
            Console.WriteLine(vende.getTelefone());
            Console.Write("Codigo setor: ");
            Console.WriteLine(vende.getCodigoSetor());
            Console.Write("Salario Base: ");
            Console.WriteLine(vende.getSalarioBase());
            Console.Write("Impostos: ");
            Console.WriteLine(vende.getImposto());
            Console.Write("Valor Vendas: ");
            Console.WriteLine(vende.getValorVendas());
            Console.Write("Comissão: ");
            Console.WriteLine(vende.getComissao());
            Console.Write("Salario: {0}", vende.calcularSalario());
            Console.WriteLine();
            Console.WriteLine();
            
            Console.Write("Nome: ");
            Console.WriteLine(fornec.getNome());
            Console.Write("End: ");
            Console.WriteLine(fornec.getEndereco());
            Console.Write("Tel: ");
            Console.WriteLine(fornec.getTelefone());
            Console.Write("Valor Vrédito: ");
            Console.WriteLine(fornec.getValorCredito());
            Console.Write("Valor Dívida: ");
            Console.WriteLine(fornec.getValorDivida());
            Console.Write("Saldo: {0} ", fornec.ObterSaldo());

        }
    }
}
