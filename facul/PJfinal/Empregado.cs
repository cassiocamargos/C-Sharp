using System;

namespace PJfinal
{
    class Empregado : Pessoa
    {
        protected int codigoSetor;
        protected double salarioBase;

        protected double imposto; 

        public int getCodigoSetor()
        {
            return this.codigoSetor;
        }
        public double getSalarioBase()
        {
            return this.salarioBase;
        }
        public double getImposto()
        {
            return this.imposto;
        }
        public void setCodigoSetor(int codSet)
        {
           
            this.codigoSetor = codSet;
        }
        public void setSalarioBase(double salBase)
        {
            this.salarioBase = salBase;
        }
        public void setImpostos (double Impost)
        {
            this.imposto = Impost;
        }
        public virtual double calcularSalario()
        {
           return salarioBase = salarioBase - (salarioBase*imposto);
        }
         public Empregado(string n, string end, string tel, int codSet, double salBase, double Impost) : base(n, end, tel)
        {
            this.setNome(n);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodigoSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(Impost);
        }

        public Empregado ()
        {

        }
    
    }

}