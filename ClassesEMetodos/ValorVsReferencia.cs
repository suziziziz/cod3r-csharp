using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class Dependente
  {
    public string Nome;
    public int Idade;
  }

  public class ValorVsReferencia
  {
    public static void Executar()
    {
      int numero = 3;
      int copiaNumero = numero;
      Console.WriteLine($"{numero} {copiaNumero}");

      numero++;

      Console.WriteLine($"{numero} {copiaNumero}");

      Dependente dep = new Dependente
      {
        Nome = "Michael Jackson AUH!!",
        Idade = 99999,
      };

      Dependente cpDep = dep;

      Console.WriteLine($"{dep.Nome} {cpDep.Nome}");
      Console.WriteLine($"{dep.Idade} {cpDep.Idade}");

      cpDep.Nome = "Ednaldo Pereira";
      dep.Idade = 19;

      Console.WriteLine($"{dep.Nome} {cpDep.Nome}");
      Console.WriteLine($"{dep.Idade} {cpDep.Idade}");
    }
  }
}
