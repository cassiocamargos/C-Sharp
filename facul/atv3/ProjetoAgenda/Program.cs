using System;

namespace ProjetoAgenda
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instanciar um horario (criar um objeto(h1) da classe Horario)
            
            Horario h1 = new Horario();
            h1.setHoras(8);
            h1.setMinutos(00);
            Console.WriteLine("h1 = {0}:{1}", h1.getHoras(), h1.getMinutos());

            Horario h2 = new Horario();
            h2.setHoras(20);
            h2.setMinutos(00);
            Console.WriteLine("h2 = {0}:{1}", h2.getHoras(), h2.getMinutos());

            Horario h3 = new Horario();
            h3.setHoras(15);
            h3.setMinutos(55);
            Console.WriteLine("h3 = {0}:{1}", h3.getHoras(), h3.getMinutos());

            Horario h4 = new Horario(23,15);
            Console.WriteLine("h4 = {0}:{1}", h4.getHoras(), h4.getMinutos());

            Horario h5 = new Horario(12,15);
            h5.setHoras(22);
            Console.WriteLine("h5 = {0}:{1}", h5.getHoras(), h5.getMinutos());

            Horario h6 = new Horario(15,12);
            h6.setMinutos(35);
            Console.WriteLine("h6 = {0}:{1}", h6.getHoras(), h6.getMinutos());

        }
    }
}
