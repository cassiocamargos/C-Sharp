using System;

namespace projetoAvaliacao
{
    class Administrador : Empregado
    {
        protected double ajCusto;

        public double getAjCusto()
        {
            return this.ajCusto;
        }

        public void setAjCusto(double ajCusto)
        {
            this.ajCusto = ajCusto;
        }

        public override double calcSalario()
        {
           return salBase = (salBase - (salBase*imposto)) + ajCusto;
        }

        public Administrador(string nome, string end, string tel, int codSet, double salBase, double imposto, double ajCusto) : base(nome, end, tel, codSet, salBase, imposto)
        {
            this.setNome(nome);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(imposto);
            this.setAjCusto(ajCusto);
           
        }
        
    }
}