using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class Produto
  {
    public string Nome;
    public double Preco;
    public static double Desconto = 0.1;

    public Produto(string nome, double preco, double desconto)
    {
      Nome = nome;
      Preco = preco;
      Desconto = desconto;
    }

    public Produto() { }

    public double CalcularDesconto()
    {
      return Preco - Preco * Desconto;
    }
  }

  public class AtributosEstaticos
  {
    public static void Executar()
    {
      Produto produto = new Produto("Caneta", 2.5, .1);
      Produto produto1 = new Produto()
      {
        Nome = "Borracha",
        Preco = 1.5,
      };
      Produto.Desconto = 0.5;

      System.Console.WriteLine($"Preço com desconto: {produto.CalcularDesconto()}");
      System.Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");

      Produto.Desconto = 0.05;

      System.Console.WriteLine($"Preço com desconto: {produto.CalcularDesconto()}");
      System.Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
    }
  }
}
