using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class ParametrosNomeados
  {
    public static void Formatar(int dia, int mes, int ano)
    {
      Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
    }

    public static void Executar()
    {
      Formatar(mes: 02, ano: 2003, dia: 11);
    }
  }
}
