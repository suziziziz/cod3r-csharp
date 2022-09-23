using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
  public class ExemploLambda
  {
    public static void Executar()
    {
      Action algoNoConsole = () =>
      {
        Console.WriteLine("This is Lambda!");
      };

      algoNoConsole();

      Func<int> jogarDado = () =>
      {
        Random random = new Random();
        return random.Next(1, 7);
      };

      Console.WriteLine("Dado {0}", jogarDado());

      Func<int, string> conversorHex = numero =>
        numero.ToString("X");

      Console.WriteLine(conversorHex(31));

      Func<int, int, int, string> formatarData = (dia, mes, ano) =>
        string.Format($"{dia:D2}/{mes:D2}/{ano:D4}");

      Console.WriteLine(formatarData(11, 03, 2003));
    }
  }
}
