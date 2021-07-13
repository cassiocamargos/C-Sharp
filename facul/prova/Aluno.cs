using System;

namespace prova
{
    public class Aluno
    {
        private string Nome;
        private string RA;
        private int Faltas;
        private double Notas;
        

        public string getRA()
        {
            return this.RA;
        }
         public void setRA(string Ra)
        {
            if(Ra == null || Ra.Trim().Length == 0)
            throw new Exception ("Insira um RA válido");
            this.RA = Ra;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setNome(string name)
        {
            if(name == null || name.Trim().Length == 0)
            throw new Exception ("Insira um nome válido");
            this.Nome = name;
        }
        public double getNota()
        {
            return this.Notas;
        }
        public void setNotas (double nota)
        {
            if(nota < 0 || nota > 10)
            throw new Exception ("Nota não permitida");
            this.Notas = nota;
        }
        public int getFaltas()
        {
            return this.Faltas;
        }        
        public void setFalta (int falta)
        {
            if(falta < 0 || falta > 60)
            throw new Exception ("Quantidade de faltas não permitidas");
            this.Faltas = falta;
        }
        
        public bool isAprovado()
        {
            if(Notas >= 5 && Faltas <= 45)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return  "Nome: " + this.getNome() + "RA: " + this.getRA() + "Faltas: " + this.getFaltas() + "Notas: " + this.getNota();
        }

                public Aluno (string name, string Ra, int falta, float nota)
        {
            this.setNome(name);
            this.setRA(Ra);
            this.setFalta(falta);
            this.setNotas(nota);
        }
        public Aluno (string name, string Ra)
        {
            this.setNome(name);
            this.setRA(Ra);
        }

    }
}