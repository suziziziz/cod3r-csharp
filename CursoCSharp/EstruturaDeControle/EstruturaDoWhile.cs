using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class EstruturaDoWhile
  {
    public static void Executar()
    {
      string? entrada;

      do
      { // É executado pelo menos uma vez mesmo que a condição seja falsa
        System.Console.Write("Nome: ");
        entrada = Console.ReadLine();

        System.Console.WriteLine($"Welcome {entrada}");
        System.Console.Write("Continuar? (S/N) ");
        entrada = Console.ReadLine();
      } while (entrada?.ToLower() == "s");
    }
  }
}
