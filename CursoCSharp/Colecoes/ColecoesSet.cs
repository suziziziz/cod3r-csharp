using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class ColecoesSet
  {
    public static void Executar()
    {
      var livro = new Produto("Game of Thrones", 45.9);

      var carrinho = new HashSet<Produto>();
      carrinho.Add(livro);

      var combo = new HashSet<Produto> {
        new Produto("Camisa", 29.9),
        new Produto("8ª Temporada Game Of Thrones", 29.9),
        new Produto("Poster", 10.0),
      };

      carrinho.UnionWith(combo);
      Console.WriteLine(carrinho.Count);
      // carrinho.RemoveAt(3);

      foreach (var item in carrinho)
      {
        Console.WriteLine("{0} - R$ {1}",
          item.Nome, item.Preco);
      }

      System.Console.WriteLine(carrinho.Count);
      carrinho.Add(livro);
      System.Console.WriteLine(carrinho.Count);
    }
  }
}
