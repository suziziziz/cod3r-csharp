using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class Interpolacao
  {
    public static void Executar()
    {
      string nome = "Notebook Game";
      string marca = "Dell";
      double preco = 5800.00;

      System.Console.WriteLine("[Concat] O " + nome + " da marca "
        + marca + " custa " + preco + ".");
      System.Console.WriteLine("[Args] O {0} da marca {1} custa {2}.",
        nome, marca, preco);
      System.Console.WriteLine($"[Direct] O {nome} da marca {marca} custa {preco}.");

      System.Console.WriteLine($"1 + 1 = {1 + 1}!");
    }
  }
}