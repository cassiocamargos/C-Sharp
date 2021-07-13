using System;

namespace PJfinal
{
    class Vendedor : Empregado
    {
        protected double valorVendas;
        protected double Comissao;

        public double getValorVendas()
        {
            return this.valorVendas;
        }
        public double getComissao()
        {
            return this.Comissao;
        }
        public void setValorVendas( double Vlvendas )
        {
            this.valorVendas = Vlvendas;
        }
        public void setComissao (double Com)
        {
            this.Comissao = Com;
        }

        public override double calcularSalario()
        {
            return salarioBase = (salarioBase - (salarioBase*imposto)) + (valorVendas*Comissao);
        }
        
        public Vendedor(string n, string end, string tel, int codSet, double salBase, double Impost, double Vlvendas, double Com) : base(n, end, tel, codSet, salBase, Impost)
        {
             this.setNome(n);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodigoSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(Impost);
            this.setValorVendas(Vlvendas);
            this.setComissao(Com);  
        }
    }

}