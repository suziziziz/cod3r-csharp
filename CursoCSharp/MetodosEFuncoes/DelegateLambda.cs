using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
  delegate double Operacao(double x, double y);

  public class DelegateLambda
  {
    public static void Executar()
    {
      Operacao sum = (x, y) => x + y;
      Operacao sub = (x, y) => x - y;
      Operacao mult = (x, y) => x * y;

      Console.WriteLine(sum(5, 5));
      Console.WriteLine(sub(5, 5));
      Console.WriteLine(mult(5, 5));
    }
  }
}
