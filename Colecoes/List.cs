using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class Produto
  {
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco)
    {
      Nome = nome;
      Preco = preco;
    }

    public override bool Equals(object? obj)
    {
      return obj is Produto produto &&
             Nome == produto.Nome &&
             Preco == produto.Preco;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(Nome, Preco);
    }
  }

  public class List
  {
    public static void Executar()
    {
      var livro = new Produto("Game of Thrones", 45.9);

      var carrinho = new List<Produto>();
      carrinho.Add(livro);

      var combo = new List<Produto> {
        new Produto("Camisa", 29.9),
        new Produto("8ª Temporada Game Of Thrones", 29.9),
        new Produto("Poster", 10.0),
      };

      carrinho.AddRange(combo);
      Console.WriteLine(carrinho.Count);

      carrinho.RemoveAt(3);

      foreach (var item in carrinho)
      {
        Console.WriteLine("[{0}] {1} - R$ {2}",
          carrinho.IndexOf(item), item.Nome, item.Preco);
      }
    }
  }
}
