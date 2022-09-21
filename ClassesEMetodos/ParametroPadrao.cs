using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class ParametroPadrao
  {
    public static int Somar(int a = 1, int b = 1)
    {
      return a + b;
    }

    public static void Executar()
    {
      System.Console.WriteLine(Somar(35, 34));
      System.Console.WriteLine(Somar(68));
      System.Console.WriteLine(Somar(b: 68));
      System.Console.WriteLine(Somar());
    }
  }
}
