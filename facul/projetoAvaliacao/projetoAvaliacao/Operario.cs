using System;

namespace projetoAvaliacao
{
    class Operario : Empregado
    {
        protected  double vProducao;
        protected double comissao;

        public double getValorProducao()
        {
            return this.vProducao;
        }

        public double getComissao()
        {
            return this.comissao;
        }

        public void setValorProducao(double vProdrucao)
        {
            this.vProducao = vProdrucao;
        }

        public void setComissao(double comissao)
        {
            this.comissao = comissao;
        }

        public override double calcSalario()
        {
             return salBase = (salBase - (salBase*imposto))  + (vProducao*comissao);
        }

        public Operario(string nome, string end, string tel, int codSet, double salBase, double imposto, double vProducao, double comissao ) : base(nome, end, tel, codSet, salBase, imposto)
        {
            this.setNome(nome);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(imposto);
            this.setValorProducao(vProducao);
            this.setComissao(comissao);
        }
    
    }
}