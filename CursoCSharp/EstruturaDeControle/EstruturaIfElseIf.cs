using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class EstruturaIfElseIf
  {
    public static void Executar()
    {
      Console.Write("Nota do aluno: ");
      string? entrada = Console.ReadLine();
      double.TryParse(entrada, out double nota);

      if (nota >= 9.0)
        Console.WriteLine("Quadro de honra!");
      else if (nota >= 7.0)
        Console.WriteLine("Aprovado!");
      else if (nota >= 5.0)
        System.Console.WriteLine("Recuperação!");
      else
        System.Console.WriteLine("Te vejo no ano que vem >:)");

      System.Console.WriteLine("Fim!");
    }
  }
}
