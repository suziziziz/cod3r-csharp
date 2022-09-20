using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class OperadoresAtribuicao
  {
    public static void Executar()
    {
      var num1 = 3;
      num1 = 7;
      num1 += 10;
      num1 -= 3;
      num1 *= 5;
      num1 /= 2;
      System.Console.WriteLine(num1);

      int a = 1;
      int b = a;
      a++;
      b--;
      System.Console.WriteLine($"a: {a}, b: {b}");

      // Copia de refêrencia
      dynamic c = new System.Dynamic.ExpandoObject();
      c.nome = "Michal Kyle";

      dynamic d = c;
      d.nome = "Sandy & Júnior";

      System.Console.WriteLine(c.nome);
    }
  }
}
