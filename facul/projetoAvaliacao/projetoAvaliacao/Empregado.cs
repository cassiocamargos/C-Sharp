using System;

namespace projetoAvaliacao
{
    class Empregado : Pessoa
    {
        protected int codSetor;
        protected double salBase;
        protected double imposto; 

        public int getCodSetor()
        {
            return this.codSetor;
        }

        public double getSalarioBase()
        {
            return this.salBase;
        }

        public double getImposto()
        {
            return this.imposto;
        }

        public void setCodSetor(int codSet)
        {
           
            this.codSetor = codSet;
        }

        public void setSalarioBase(double salBase)
        {
            this.salBase = salBase;
        }

        public void setImpostos (double imposto)
        {
            this.imposto = imposto;
        }

        public virtual double calcSalario()
        {
           return salBase = salBase - (salBase*imposto);
        }

         public Empregado(string nome, string end, string tel, int codSet, double salBase, double imposto) : base(nome, end, tel)
        {
            this.setNome(nome);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(imposto);
        }

        public Empregado ()
        {

        }
    
    }
}