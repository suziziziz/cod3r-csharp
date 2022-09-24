using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class Membros
  {
    public static void Executar()
    {
      Pessoa pessoa = new Pessoa();
      pessoa.Nome = "Michal Kyle";
      pessoa.Idade = 38;

      // Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos");

      pessoa.ApresentarNoTerminal();
      pessoa.Zerar();
      pessoa.ApresentarNoTerminal();

      var pessoa1 = new Pessoa();
      pessoa1.Nome = "Um maluco no pedaço";
      pessoa1.Idade = 12;

      var apresentacaoDaPessoa1 = pessoa1.Apresentar();
      System.Console.WriteLine(apresentacaoDaPessoa1);
    }
  }
}
