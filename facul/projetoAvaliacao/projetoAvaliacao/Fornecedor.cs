using System;

namespace projetoAvaliacao
{
        class Fornecedor : Pessoa
    {
        
        protected double vCredito;
        protected double vDivida;

        public double getValorCredito()
        {
            return this.vCredito;
        }

        public double getValorDivida()
        {
            return this.vDivida;
        }

        public void setValorCredito (double vCredito)
        {
            this.vCredito = vCredito;
        }


        public void setValorDivida (double vDivida)
        {
            this.vDivida = vDivida;
        }

        public double ObterSaldo()
        {
            double saldo;
           return saldo = vCredito - vDivida;
        }

         public Fornecedor(string nome, string end, string tel, double vCredito, double vDivida) : base(nome, end, tel)
        {
            this.setNome(nome);
            this.setEndereco(end);
            this.setTelefone(tel);
            this.setValorCredito(vCredito);
            this.setValorDivida(vDivida);
        }
       
    }
}