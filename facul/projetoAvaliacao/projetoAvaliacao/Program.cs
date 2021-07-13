using System;

namespace projetoAvaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor fornec = new Fornecedor ("Luiz", "Rua. YYYY", "19 92004-4998", 17589.23, 9665.57);

            Administrador adm = new Administrador ("Cassio", "Rua. WXYZ", "11 95289-4556", 100, 4500.00, 0.14, 200.00);

            Operario oper = new Operario ("Joao", "Rua. ZYXW", "11 95864-5220", 200, 2000.00, 0.14, 96.72, 0.10);

            Vendedor vend = new Vendedor ("Julia", "Rua. XXXX", "11 94638-8542", 300, 2500.50, 0.14, 349.90, 0.15);
            
            Console.Write("Nome: ");
            Console.WriteLine(fornec.getNome());
            Console.Write("Endereço: ");
            Console.WriteLine(fornec.getEndereco());
            Console.Write("Telefone: ");
            Console.WriteLine(fornec.getTelefone());
            Console.Write("Valor de crédito: ");
            Console.WriteLine(fornec.getValorCredito());
            Console.Write("Valor de dívida: ");
            Console.WriteLine(fornec.getValorDivida());
            Console.Write("Saldo: {0} ", fornec.ObterSaldo());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Nome: ");
            Console.WriteLine(adm.getNome());
            Console.Write("Endereço: ");
            Console.WriteLine(adm.getEndereco());
            Console.Write("Telefone: ");
            Console.WriteLine(adm.getTelefone());
            Console.Write("Código do setor: ");
            Console.WriteLine(adm.getCodSetor());
            Console.Write("Salário Base: ");
            Console.WriteLine(adm.getSalarioBase());
            Console.Write("Impostos: ");
            Console.WriteLine(adm.getImposto());
            Console.Write("Ajuda de custo: ");
            Console.WriteLine(adm.getAjCusto());
            Console.Write("Salário: {0}", adm.calcSalario());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Nome: ");
            Console.WriteLine(oper.getNome());
            Console.Write("Endereço: ");
            Console.WriteLine(oper.getEndereco());
            Console.Write("Telefone: ");
            Console.WriteLine(oper.getTelefone());
            Console.Write("Código do setor: ");
            Console.WriteLine(oper.getCodSetor());
            Console.Write("Salário Base: ");
            Console.WriteLine(oper.getSalarioBase());
            Console.Write("Impostos: ");
            Console.WriteLine(oper.getImposto());
            Console.Write("Valor de Produção: ");
            Console.WriteLine(oper.getValorProducao());
            Console.Write("Comissão: ");
            Console.WriteLine(oper.getComissao());
            Console.Write("Salário: {0}", oper.calcSalario());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Nome: ");
            Console.WriteLine(vend.getNome());
            Console.Write("Endereço: ");
            Console.WriteLine(vend.getEndereco());
            Console.Write("Telefone: ");
            Console.WriteLine(vend.getTelefone());
            Console.Write("Código setor: ");
            Console.WriteLine(vend.getCodSetor());
            Console.Write("Salário Base: ");
            Console.WriteLine(vend.getSalarioBase());
            Console.Write("Impostos: ");
            Console.WriteLine(vend.getImposto());
            Console.Write("Valor de Vendas: ");
            Console.WriteLine(vend.getValorVendas());
            Console.Write("Comissão: ");
            Console.WriteLine(vend.getComissao());
            Console.Write("Salário: {0}", vend.calcSalario());

        }
    }
}