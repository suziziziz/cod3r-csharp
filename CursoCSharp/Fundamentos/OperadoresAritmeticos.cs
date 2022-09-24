using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class OperadoresAritmeticos
  {
    public static void Executar()
    {
      // Preço Desconto
      var preco = 1000;
      var imposto = 355;
      var desconto = 0.1;

      double total = preco + imposto;
      var totalComDesconto = total - total * desconto;
      Console.WriteLine($"O preço final é {totalComDesconto}");

      // IMC
      double peso = 91.2;
      double altura = 1.82;
      double imc = peso / Math.Pow(altura, 2);
      System.Console.WriteLine($"O IMC é {imc}");

      int par = 24;
      int impar = 55;
      Console.WriteLine($"{par}/2 tem resto {par % 2}");
      Console.WriteLine($"{impar}/2 tem resto {impar % 2}");
    }
  }
}