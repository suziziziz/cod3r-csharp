using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
  public class ParamDelegate
  {
    public delegate int Operacao(int x, int y);

    public static int Soma(int x, int y)
    {
      return x + y;
    }
    public static string Calculadora(Operacao op, int x, int y)
    {
      var result = op(x, y);
      return $"Resultado: {result}";
    }

    public static void Executar()
    {
      Operacao subtracao = (int x, int y) => x - y;

      Console.WriteLine(Calculadora(subtracao, 4, 4));
      Console.WriteLine(Calculadora(Soma, 4, 4));
    }
  }
}
