using System;

namespace PJfinal
{
        class Fornecedor : Pessoa
    {
        protected double valorCredito;
        protected double valorDivida;


        public double getValorCredito()
        {
            return this.valorCredito;
        }
        public double getValorDivida()
        {
            return this.valorDivida;
        }
        public void setValorCredito (double VlCred)
        {
            this.valorCredito = VlCred;
        }
        public void setValorDivida (double VlDiv)
        {
            this.valorDivida = VlDiv;
        }

        public double ObterSaldo()
        {
            double saldo;
           return saldo = valorCredito - valorDivida;

        }
         public Fornecedor(string n, string end, string tel, double VlCred, double VlDiv) : base(n, end, tel)
        {
            this.setNome(n);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setValorCredito(VlCred);
            this.setValorDivida(VlDiv);

        }
       
    }
}