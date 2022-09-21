using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public enum Genero
  {
    Acao,
    Aventuram,
    Terror,
    Animacao,
    Comedia,
  };

  public class Filme
  {
    public string Titulo;
    public Genero GeneroDoFilme;
  }

  public class ExEnum
  {
    public static void Executar()
    {
      int id = (int)Genero.Animacao;
      System.Console.WriteLine(id);

      var filmeParaFamilia = new Filme()
      {
        Titulo = "Sharktank e Lava Carro",
        GeneroDoFilme = Genero.Comedia,
      };

      Console.WriteLine("{0} é do gênero {1}!",
        filmeParaFamilia.Titulo,
        filmeParaFamilia.GeneroDoFilme);
    }
  }
}
