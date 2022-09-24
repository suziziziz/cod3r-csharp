using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class OperadoresUnarios
  {
    public static void Executar()
    {
      var valorNegativo = -5;
      var numero1 = 2;
      var numero2 = 3;
      var booleano = true;

      System.Console.WriteLine(-valorNegativo);
      System.Console.WriteLine(!booleano);

      numero1++;
      System.Console.WriteLine(numero1);

      --numero1;
      System.Console.WriteLine(numero1);

      //                                    Esse número é decrementado
      //                                    depois da comparação
      System.Console.WriteLine(numero1++ == --numero2);
      System.Console.WriteLine($"{numero1} {numero2}");
    }
  }
}
