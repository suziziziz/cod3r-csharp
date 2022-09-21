using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class Continue
  {
    public static void Executar()
    {
      int intervalo = 50;
      System.Console.WriteLine($"pares entre 1 e {intervalo}");

      for (int i = 1; i <= intervalo; i++)
      {
        if (i % 2 == 1) continue;

        Console.Write($"{i} ");
      }
    }
  }
}
