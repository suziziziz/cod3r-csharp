using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class Break
  {
    public static void Executar()
    {
      Random random = new Random();
      int numero = random.Next(1, 51);
      bool valid = false;

      System.Console.WriteLine($"{numero} foi sorteado");

      for (int i = 1; i <= 50; i++)
      {
        System.Console.Write($"{i} é o numero certo? ");

        valid = i == numero;

        System.Console.WriteLine(valid ? "Sim!" : "Não!");
        if (valid) break;
      }

      System.Console.WriteLine("Exit");
    }
  }
}
