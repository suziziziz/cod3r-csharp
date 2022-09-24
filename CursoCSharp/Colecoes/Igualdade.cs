using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class Igualdade
  {
    public static void Executar()
    {
      var p1 = new Produto("Caneta", 1.50);
      var p2 = new Produto("Caneta", 1.50);
      var p3 = p2;

      System.Console.WriteLine(p1 == p2);
      System.Console.WriteLine(p3 == p2);

      System.Console.WriteLine(p1.Equals(p2));
      // System.Console.WriteLine(p1.GetHashCode(p2));
    }
  }
}
