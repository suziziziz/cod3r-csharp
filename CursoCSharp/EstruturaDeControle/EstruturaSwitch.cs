using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class EstruturaSwitch
  {
    public static void Executar()
    {
      System.Console.Write("Acalie com a nota de 0 a 5: ");
      int.TryParse(Console.ReadLine(), out int nota);

      switch (nota)
      {
        case 0:
          System.Console.WriteLine("Péssimo T°T");
          break;

        case 1:
        case 2:
          System.Console.WriteLine("Ruim :(");
          break;

        case 3:
          System.Console.WriteLine("Reguar :|");
          break;

        case 4:
          System.Console.WriteLine("Bom :P");
          break;

        case 5:
          System.Console.WriteLine("Maravilhoso ü");
          break;

        default:
          System.Console.WriteLine("Nota inválida '-'");
          break;
      }

      System.Console.WriteLine("Agredeçemos a avaliação");
    }
  }
}
