using System;

namespace atv6
{   
    class Funcionarios
    {
        //ATRIBUTOS
        private string nome;
        private string CPF;

        private int carrosNovos;
        private int carrosUsados;
        private float valorAcessorio;
        private double salario;

        //CONSTRUTOR
        public Funcionarios (string n, string cpf, int carrosN, int carrosU, float acessorio)
        {
            setNome(n);
            setCPF(cpf);
            setCarrosNovos(carrosN);
            setCarrosUsados(carrosU);
            setValorAcessorio(acessorio);
        }
        public Funcionarios (string n, string cpf)
        {  
            setNome(n);
            setCPF(cpf);
        }

        
        //METODOS
        public string getNome () 
        {
            return this.nome;
        }
        public string getCPF ()
        {
            return this.CPF;
        }
        public int getcarrosNovos ()
        {
            return this.carrosNovos;
        }
        public int getCarrosUsados ()
        {
            return this.carrosUsados;
        }
        public float getValorAcessorio ()
        {
            return this.valorAcessorio;
        }
        public double getSalario()
        {              
            return this.getcarrosNovos()* 300 + this.getCarrosUsados() * 150 + this.getValorAcessorio()*0.1;
           // R$ 300,00 para cada carro zero vendido;
           // R$ 150,00 para cada carro usado vendido;
           // 10% do valor vendido em acessórios.
        }
        public double getSalario (double perdesc)
        {
            return this.getSalario() * (1 - perdesc / 100);
        }
        
        public void setNome (string n)
        {
            if(n==null || n.Trim().Length == 0)
                throw new Exception ("Nome Inválido!");

            this.nome=n;
        }
        public void setCPF (string cpf)
        {
            this.CPF=cpf;
        }
        public void setCarrosNovos (int carrosN)
        {
            if(carrosN>30 || carrosN<0)
                throw new Exception ("Quantidade de carros inválido");

            this.carrosNovos=carrosN;
        }
        public void setCarrosUsados (int carrosU)
        {
            if(carrosU>30 || carrosU<0)
                throw new Exception ("Quantidade de carros inválid");
            this.carrosUsados=carrosU;
        }
        public void setValorAcessorio (float acessorio)
        {
            if(acessorio<0)
                throw new Exception ("Valor inválido");
            this.valorAcessorio=acessorio;
        }


       
    }
}