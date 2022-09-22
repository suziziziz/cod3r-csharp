using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class ColecoesDictionary
  {
    public static void Executar()
    {
      var filmes = new Dictionary<int, string>();

      filmes.Add(1972, "O Poderoso Chefão");
      filmes.Add(1976, "Taxi Driver");
      filmes.Add(1994, "Pulp Fiction");
      filmes.Add(1999, "Clube da Luta");

      if (filmes.ContainsKey(1994))
      {
        System.Console.WriteLine($"1994: {filmes[1994]}");
        System.Console.WriteLine($"1994: {filmes.GetValueOrDefault(1994)}");
      }

      System.Console.WriteLine(filmes.ContainsValue("Shrek"));
      System.Console.WriteLine($"removed 1999: {filmes.Remove(1999)}");

      filmes.TryGetValue(1994, out string? filme1994);
      System.Console.WriteLine($"Filme {filme1994}");

      foreach (var item in filmes.Keys)
      {
        System.Console.WriteLine(item);
      }

      foreach (var item in filmes.Values)
      {
        System.Console.WriteLine(item);
      }

      foreach (var filme in filmes)
      {
        System.Console.WriteLine($"{filme.Key}: {filme.Value}");
      }
    }
  }
}
