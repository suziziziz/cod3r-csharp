using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
  public static class ExensoesInteiro
  {
    public static int Soma(this int num, int outroNumero)
    {
      return num + outroNumero;
    }

    public static int Subtracao(this int num, int outroNumero)
    {
      return num - outroNumero;
    }
  }

  public class ExtensaoMetodo
  {
    public static void Executar()
    {
      int numero = 5;

      Console.WriteLine(numero.Soma(3));
      Console.WriteLine(numero.Subtracao(3));
      Console.WriteLine(2.Soma(3));
      Console.WriteLine(2.Subtracao(3));
    }
  }
}
