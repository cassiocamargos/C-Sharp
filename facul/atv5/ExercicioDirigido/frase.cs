using System;

namespace ExercicioDirigido
{
    class Frase
    {
    private string[] ListaDePalavras;
    private int QuantidadeDePalavras;
    public Frase()
    {
        this.ListaDePalavras = new string[100];
        this.QuantidadeDePalavras = 0;
    }
    public void AdicionarPalavra(string novaPalavra)
    {
        this.ListaDePalavras[this.QuantidadeDePalavras]=novaPalavra;
        this.QuantidadeDePalavras++;
    }
    public void RemoverPalavra(string palavra)
    {
        bool achou = false; 
        int i; 
        for (i=0;i<=this.QuantidadeDePalavras-1;i++)
        {
            if (this.ListaDePalavras[i] == palavra)
            {
            
                achou = true;
                break;
            }
        }
        if (achou)
        {
            int j; 
            for (j = i; j <= this.QuantidadeDePalavras - 1; j++)
            {
                this.ListaDePalavras[j] = this.ListaDePalavras[j + 1];
            }
            this.QuantidadeDePalavras--;
        }
    }
    public void MostrarFrase()
    {
        int i;
        for (i = 0; i <=this.QuantidadeDePalavras-1; i++)
        {
            Console.Write(this.ListaDePalavras[i]); 
            Console.Write(" "); 
        }
        Console.WriteLine(); 
    }
    public void MostrarFraseInvertida()
    {
        int i;
        for (i = this.QuantidadeDePalavras-1; i >= 0; i--)
        {
            Console.Write(this.ListaDePalavras[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    }
}