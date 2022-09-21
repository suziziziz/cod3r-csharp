using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class Params
  {
    public static void Recepcionar(params string[] pessoas)
    {
      foreach (var pessoa in pessoas)
      {
        System.Console.WriteLine($"Hello {pessoa}!");
      }
    }

    public static void Executar()
    {
      Recepcionar(
        "Anitta",
        "Linn",
        "Zack de la Rocha",
        "Maynard James",
        "Corey Taylor",
        "World"
      );
    }
  }
}
