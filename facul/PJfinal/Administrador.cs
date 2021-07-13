using System;

namespace PJfinal
{
    class Administrador : Empregado
    {
        protected double ajudaDeCusto;


        public double getAjudaDeCusto()
        {
            return this.ajudaDeCusto;
        }
        public void setAjudaDeCusto(double ajudaCust)
        {
            this.ajudaDeCusto = ajudaCust;
        }

        public override double calcularSalario()
        {
           return salarioBase = (salarioBase - (salarioBase*imposto)) + ajudaDeCusto;
        }
        public Administrador(string n, string end, string tel, int codSet, double salBase, double Impost, double ajudaCust) : base(n, end, tel, codSet, salBase, Impost)
        {
            this.setNome(n);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setCodigoSetor(codSet);
            this.setSalarioBase(salBase);
            this.setImpostos(Impost);
            this.setAjudaDeCusto(ajudaCust);
           
        }
    }

}