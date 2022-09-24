using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
  public class FilhoReconhecido : SubCelebridade
  {
    public new void MeusAcessos()
    {
      System.Console.WriteLine("Filho Reconecido...");

      System.Console.WriteLine(InfoPublica);
      System.Console.WriteLine(CorDoOlho);
      System.Console.WriteLine(NumeroCelular);
      System.Console.WriteLine(JeitoDeFalar);
      System.Console.WriteLine(SegredoFamilia);
      // System.Console.WriteLine(UsaMuitoPhotoshop);
    }
  }
}
