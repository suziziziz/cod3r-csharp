using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class OperadoresLogicos
  {
    public static void Executar()
    {
      var getJob1 = false;
      var getJob2 = false;

      var buyTv50 = getJob1 && getJob2;

      Console.WriteLine($"Comprou a Tv de 50 polegadas? {buyTv50}");

      var buyIcecream = getJob1 || getJob2;
      Console.WriteLine($"Comprou o sorvete? {buyIcecream}");

      var buyTv32 = getJob1 ^ getJob2;
      Console.WriteLine($"Comprou a tv32? {buyTv32}");

      Console.WriteLine($"Mais saudável? {!buyIcecream}");
    }
  }
}