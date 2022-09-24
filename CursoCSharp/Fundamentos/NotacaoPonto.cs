using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class NotacaoPonto
  {
    public static void Executar()
    {
      var saudacao = "Olá"
        .ToUpper()
        .Insert(3, " World!")
        .Replace("World", "Mundo");

      System.Console.WriteLine(saudacao);
      System.Console.WriteLine("Test".Length);

      string? valorImportante = null;
      System.Console.WriteLine(valorImportante?.Length);
    }
  }
}