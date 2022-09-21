using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class EstruturaIfElse
  {
    public static void Executar()
    {
      double nota = 7.0;
      if (nota >= 7.0)
      {
        System.Console.WriteLine("Aprovado!");
        System.Console.WriteLine("Não fez mais que sua obrigação... >:)");
      }
      else
      {
        System.Console.WriteLine("Recuperação!");
        System.Console.WriteLine("Que feio!");
      }
    }
  }
}
