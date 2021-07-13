using System;

namespace PJfinal
{
    
    class Pessoa
    {
        protected string nome;
        protected string endereco;
        protected string telefone;

        public Pessoa ()
        {
            
        }

        public Pessoa (string n, string end, string tel)
        {
            this.setNome(n);
            this.setEndereco(end);
            this.setTelefone(tel);
        }

        public string getNome()
        {
            return this.nome;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public string getTelefone()
        {
            return this.telefone;
        }
        public void setNome(string n)
        {
        
            this.nome = n;
        }
        public void setEndereco(string end)
        {
         
            this.endereco = end;
        }
        public void setTelefone(string tel)
        {
            this.telefone = tel;
        }

    }

}