using System;

namespace ContaCorrente
{

    public class ContaCorrente
    {
        //ATRIBUTOS
        private string titular;
        private float saldo;
        private int numero;
      

        //CONSTRUTOR

        public ContaCorrente()
        {
            setTitular("Nome");
            setNumero(0);
            this.saldo = 0;
        }

        //não padrão
        public ContaCorrente(string t1, int n1, float saldo)
        {
            setTitular(t1);
            setNumero(n1);
            if(saldo < 0)
            {
                throw new Exception("não existe");
            }
            this.saldo = saldo;
             
        }

        //METODOS

        public string getTitular()
        {
            return this.titular;
        }

        public float getSaldo()
        {
            return this.saldo;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setTitular(string newtitular)
        {
            if(newtitular==null || newtitular.Trim().Length==0)
                throw new Exception("Esse nome de titular não existe!");

            this.titular=newtitular;
        }

        public void setNumero(int n)
        {
            if(n < 0)
            {
                throw new Exception("Esse número não existe!");
            }
            this.numero = n;
        }

        public void setDepositar(float novoDeposito)
        {
            if(novoDeposito < 0)
            {
                throw new Exception("Esse deposito não existe!");
            }
            this.saldo += novoDeposito;
        }

        public void setSaque(float novoSaque)
        {
            if(novoSaque < 0)
            {
                throw new Exception("Esse saque não existe!");
            }

            this.saldo -= novoSaque;
        }
    }
}