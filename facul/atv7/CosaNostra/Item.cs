using System;

namespace CosaNostra
{
    class Item
    {
        private int codigo;
        private string nome;
        private string dataAquisicao;
        private string autores;

    

        public Item (int cod, string n, string d, string a)
        {
            this.setCodigo (cod);
            this.setNome (n);
            this.setData (d);
            this.setAutores(a);
        }

        public int getCodigo()
        {
            return this.codigo;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getData()
        {
            return this.dataAquisicao;
        }
        public string getAutores()
        {
            return this.autores;
        }
        public void setCodigo(int cod)
        {
            if(cod<0)
                throw new Exception ("Identificação inválida");
            this.codigo = cod;
        }
        public void setNome( string n)
        {
            if(n==null || n.Trim().Length==0)
                throw new Exception ("Nome inválido");
            this.nome = n;
        }
        public void setData(string d)
        {
            if(d==null)
                throw new Exception ("Data inválida!");
            this.dataAquisicao = d;
        }
        public void setAutores(string a)
        {
            if(a==null || a.Trim().Length==0)
                throw new Exception ("Autores inválidos");
            this.autores = a;

        }
        /*
        // atributos
        private int codigo;
        private DateTime dataAquisicao;
        private string nome;
        private string autores;

        // construtores

        // métodos get/set
        public int getCodigo()
        {
            return this.codigo;
        }

        public string getNome()
        {
            return this.nome;
        }
        
        public string getData()
        {
            return this.dataAquisicao;
        }
        
        public string getAutores()
        {
            return this.autores;
        }

        public void setCodigo(int c)
        {
            if (c<=0)
                throw new Exception("Código inválido!");

            this.codigo = c;
        }

        public void setNome( string n)
        {
            if(n==null || n.Trim().Length==0)
                throw new Exception ("Nome inválido");
            this.nome = n;
        }

        public DateTime getDataAquisicao()
        {
            return this.dataAquisicao;
        }

        public void setDataAquisicao(DateTime dta)
        {
            if (dta==null)
                throw new Exception("Data inválida!");
            this.dataAquisicao = dta;
        }

        {
            if(a==null || a.Trim().Length==0)
                throw new Exception ("Autores inválidos");
            this.autores = a;
        }
        */
    }
}