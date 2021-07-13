using System;

namespace ProjetoAgenda
{
    public class Horario
    {
        //atributos
        private int horas; // de 0 ate 23
        private int minutos; // de 0 ate 59

        // metodos construtores
        
        public Horario() //construtor padrão
        {
            //setHoras(0);
            //setMinutos(0);
        }
        
        
        public Horario(int h, int m) // construtor nao padrao
        {
            setHoras(h);
            setMinutos(m);
        }
        

        // metodos
        public int getHoras()
        {
            return horas;
        }

        public int getMinutos()
        {
            return minutos;
        }

        public void setHoras(int novaHora)
        {
            if (novaHora < 0 || novaHora > 23)
                throw new Exception("Hora invalida!");
            horas = novaHora;
        }

        public void setMinutos(int novoMinuto)
        {
            if (novoMinuto < 0 || novoMinuto > 59)
                throw new Exception("Minuto invalido!");
            minutos = novoMinuto;
        }

    }
    
}
