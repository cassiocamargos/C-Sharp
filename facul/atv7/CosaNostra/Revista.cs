using System;

namespace CosaNostra
{
    class Revista : Publicacao
    {
        private int volume;
        private string editora;
        private string PrincipalAssunto;
        public Revista(int v, string edit, string princA, int ano, int cod, string n, string d, string a) : base(ano, cod, n, d, a)
        {
            this.setVolume(v);
            this.setEditora(edit);
            this.setPrincAssunto(princA);
        }
        public int getVolume()
        {
            return this.volume;
        }
        public string getEditora()
        {
            return this.editora;
        }
        public string getPrincAssunto()
        {
            return this.PrincipalAssunto;
        }
        public void setVolume(int v)
        {
            if(v<0)
                throw new Exception ("Volume inválido");
            this.volume = v;
        }
        public void setEditora(string edit)
        {
            if(edit==null || edit.Trim().Length==0)
                throw new Exception ("Nome de editora inválido");
            this.editora = edit;
        }
        public void setPrincAssunto(string princA)
        {
            if(princA==null|| princA.Trim().Length==0)
                throw new Exception ("Principais assuntos inválido");
            this.PrincipalAssunto = princA;
        }
    }
}