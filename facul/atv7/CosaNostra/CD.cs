using System;

namespace CosaNostra
{
    class CD : Item
    {
        private string genero;
        private string nomeMusica;

        public CD(string g, string nomeM, int cod, string n, string d, string a) : base(cod, n, d, a)
        {
            this.setNomeMusica(nomeM);
            this.setGenero(g);
        }
        public string getGenero()
        {
            return this.genero;
        }

        public string getNomeMusica()
        {
            return this.nomeMusica;
        }
        public void setGenero(string g)
        {
            if(g==null|| g.Trim().Length==0)
                throw new Exception ("Nome de  genero inválido");
            this.genero = g;
        }
        public void setNomeMusica(string nomeM)
        {
            if(nomeM == null || nomeM.Trim().Length==0)
                throw new Exception ("Nome de musica inválido");
            this.nomeMusica = nomeM;
        }
    }
}