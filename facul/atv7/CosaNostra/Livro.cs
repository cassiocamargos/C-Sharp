using System;

namespace CosaNostra
{
    class Livro : Publicacao
    {
        public string editora;
        public string Assunto;

        public Livro (string ed, string Ass, int ano,int cod, string n, string d, string a) : base(ano, cod, n, d, a)
        {
            this.setEditora(ed);
            this.setAssunto(Ass);
        }
        public string getEditora ()
        {
            return this.editora;
        }
        public string getAssunto()
        {
            return this.Assunto;
        }
        public void setEditora(string ed)
        {
            if(ed==null || ed.Trim().Length==0)
                throw new Exception ("Nome de editora inválido");
            this.editora = ed;
        }
        public void setAssunto (string Ass)
        {
            if(Ass==null || Ass.Trim().Length==0)
                throw new Exception ("Assunto inválido");
            this.Assunto = Ass;   
        }
    }
}