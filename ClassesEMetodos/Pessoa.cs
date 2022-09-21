using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class Pessoa
  {
    public string Nome;
    public int Idade;

    public string Apresentar()
    {
      return string.Format($"Meu nome é {Nome} e tenho {Idade} anos!");
    }

    public void ApresentarNoTerminal()
    {
      System.Console.WriteLine(Apresentar());
    }

    public void Zerar()
    {
      Nome = "";
      Idade = 0;
    }
  }
}
