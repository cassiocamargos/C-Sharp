using System;

namespace CosaNostra
{
    class Publicacao : Item
    {
        private int AnoPubli;
        
        public Publicacao (int ano, int cod, string n, string d, string a) : base(cod, n, d, a)
        {
            this.setAno(ano);
        }

        public int getAno()
        {
            return this.AnoPubli;
        }
        public void setAno(int ano)
        {
            if(ano<1500)
                throw new Exception ("Ano inválido");
            this.AnoPubli = ano;
        }
    }
}