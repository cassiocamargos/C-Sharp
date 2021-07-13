using System;

namespace projetoAvaliacao
{   
    class Pessoa
    {
        protected string nome;
        protected string endereco;
        protected string telefone;

        public Pessoa ()
        {
            
        }

        public Pessoa (string nome, string end, string tel)
        {
            this.setNome(nome);
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

        public void setNome(string nome)
        {
        
            this.nome = nome;
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