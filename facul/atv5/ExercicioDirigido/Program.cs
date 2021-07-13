using System;

namespace ExercicioDirigido
{
    class Program
    {
        static void Main(string[] args)
        {
            Frase f = new Frase ();
            f.AdicionarPalavra("Cassio");
            f.AdicionarPalavra("Camargos");
            f.AdicionarPalavra("Fernandes");
            f.AdicionarPalavra("Silva");
            f.RemoverPalavra("Silva");
            f.MostrarFrase();
            f.MostrarFraseInvertida();
            
        }
    }
}
