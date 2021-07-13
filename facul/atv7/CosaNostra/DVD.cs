using System;

namespace CosaNostra
{
    class DVD : Item
    {
        private string tipo;
        private string desc; //descrição
        public DVD(string tipof, string des, int cod, string n, string d, string a) : base(cod, n, d, a)
        {
            this.setTipo(tipof);
            this.setDesc(des);
        }

        public string getTipo()
        {
            return this.tipo;
        }
        public string getDesc()
        {
            return this.desc;
        }
        public void setTipo(string tipof)
        {
            if(tipof==null|| tipof.Trim().Length==0)
                throw new Exception ("Tipo de dvd inválido");
            this.tipo = tipof;
        }
        public void setDesc (string des)
        {
            if(des==null|| des.Trim().Length==0)
                throw new Exception ("Descriçaõ de dvd inválido");
            this.desc = des;
        }
    }
}