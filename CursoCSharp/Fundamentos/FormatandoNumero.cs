using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
  public class FormatandoNumero
  {
    public static void Executar()
    {
      double valor = 15.175;
      Console.WriteLine(valor.ToString("F1"));
      Console.WriteLine(valor.ToString("C"));
      Console.WriteLine(valor.ToString("P"));
      Console.WriteLine(valor.ToString("#.##"));

      CultureInfo cultureInfo = new CultureInfo("pt-BR");
      Console.WriteLine(valor.ToString("C2", cultureInfo));

      int inteiro = 256;
      Console.WriteLine(inteiro.ToString("D10"));
    }
  }
}