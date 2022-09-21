using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class Cliente
  {
    public string Nome;
    public readonly DateTime Nascimento;
    public const int x = 1;

    public Cliente(string nome, DateTime nascimento)
    {
      Nome = nome;
      Nascimento = nascimento;
    }

    public string GetDataDeNascimento()
    {
      return String.Format("{0}/{1}/{2}",
        Nascimento.Day,
        Nascimento.Month,
        Nascimento.Year
      );
    }
  }

  public class Readonly
  {
    public static void Executar()
    {
      var novoCliente = new Cliente(
        "Kratos", new DateTime(1987, 5, 22));

      Console.WriteLine(novoCliente.Nome);
      Console.WriteLine(novoCliente.GetDataDeNascimento());
    }
  }
}
