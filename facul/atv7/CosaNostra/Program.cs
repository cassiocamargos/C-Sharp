using System;

namespace CosaNostra
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação do objeto item
            Item i = new Item (12345, "Gibi", "17-02-2021", "Cássio");
            //criação do objeto cd
            CD cdd = new CD ("pop", "Thriller",12354,"album Thriller","01-12-1982", "XXXXX");
            //criação do objeto dvd
            DVD dvd2  = new DVD ("filme", "ação/ fantasia", 12534, "Vingadores Ultimato","25-04-2019" , "XXXXX" );
            //criação do objeto publicação
            Publicacao publi = new Publicacao (2021, 15234, "XXXXX", "01-01-2021" , "Joao");
            //criação do objeto revista
            Revista rev = new Revista (2,"Veja", "Noticias", 2020, 51234, "XXXXX","01-04-2020", "pedro" );
            //criação do objeto livro
            Livro l = new Livro ("XXXXX", "YYYYY", 2019, 54321, "YYYYY","06-06-2019" , "Mariazinha");

            Console.WriteLine("ITEM");
            Console.WriteLine(i.getCodigo());
            Console.WriteLine(i.getNome());
            Console.WriteLine(i.getData());
            Console.WriteLine(i.getAutores());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CD");
            Console.WriteLine(cdd.getGenero());
            Console.WriteLine(cdd.getNomeMusica());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DVD");
            Console.WriteLine(dvd2.getTipo());
            Console.WriteLine(dvd2.getDesc());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PUBLICAÇÃO");
            Console.WriteLine(publi.getAno());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("REVISTA");
            Console.WriteLine(rev.getVolume());
            Console.WriteLine(rev.getEditora());
            Console.WriteLine(rev.getPrincAssunto());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("LIVRO");
            Console.WriteLine(l.getEditora());
            Console.WriteLine(l.getAssunto());

            /*Revista r = new Revista();
           
            r.setDataAquisicao(new DateTime(2021,4,1));
            r.setCodigo(10);
            
            Console.WriteLine(r.getCodigo());
            Console.WriteLine(r.getDataAquisicao());*/
        }
    }
}
