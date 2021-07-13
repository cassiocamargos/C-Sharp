using System;

namespace projetoAvaliacao
{
    class Vendedor : Empregado
    {
        protected double vVendas;
        protected double Comissao;

        public double getValorVendas()
        {
            return this.vVendas;
        }

        public double getComissao()
        {
            return this.Comissao;
        }

        public void setValorVendas( double vVendas )
        {
            this.vVendas = vVendas;
        }

        public void setComissao (double comissao)
        {
            this.Comissao = comissao;
        }

        public override double calcSalario()
        {
            return salBase = (salBase - (salBase*imposto)) + (vVendas*Comissao);
        }
        
        public Vendedor(string nome, string end, string tel, int codSet, double salBase, double imposto, double vVendas, double comissao) : base(nome, end, tel, codSet, salBase, imposto)
        {
             this.setNome(nome);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(imposto);
            this.setValorVendas(vVendas);
            this.setComissao(comissao);  
        }

    }
}