using System;

namespace PJfinal
{
    class Operario : Empregado
    {
        protected  double valorProducao;
        protected double comissao;

        public double getValorProducao()
        {
            return this.valorProducao;
        }
        public double getComissao()
        {
            return this.comissao;
        }
        public void setValorProducao(double VlProdrucao)
        {
            this.valorProducao = VlProdrucao;
        }
        public void setComissao(double Com)
        {
            this.comissao = Com;
        }

        public override double calcularSalario()
        {
             return salarioBase = (salarioBase - (salarioBase*imposto))  + (valorProducao*comissao);
        }
        public Operario(string n, string end, string tel, int codSet, double salBase, double Impost, double VlProdrucao, double Com ) : base(n, end, tel, codSet, salBase, Impost)
        {
            this.setNome(n);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodigoSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(Impost);
            this.setValorProducao(VlProdrucao);
            this.setComissao(Com);
        }
    
    }

}