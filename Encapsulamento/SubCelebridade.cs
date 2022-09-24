using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
  public class SubCelebridade
  {
    /* Todos */
    public string InfoPublica = "Me segue no twitter  Ednaldo Pereira";

    // Herança
    protected string CorDoOlho = "Castanho";

    // Mesmo projeto (assembly)
    internal ulong NumeroCelular = 55_14_999999999;

    // Herança ou mesmo projeto
    protected internal string JeitoDeFalar = "Baanido!! Desbanido!";

    // Mesma class ou herança no mesmo projeto (c# >= 7.2)
    private protected string SegredoFamilia = "Secreto 0_o";

    // Private é o padrão
    bool UsaMuitoPhotoshop = false;

    public void MeusAcessos()
    {
      Console.WriteLine("SuaCelebridade...");

      Console.WriteLine(InfoPublica);
      Console.WriteLine(CorDoOlho);
      Console.WriteLine(NumeroCelular);
      Console.WriteLine(JeitoDeFalar);
      Console.WriteLine(SegredoFamilia);
      Console.WriteLine(UsaMuitoPhotoshop);
    }
  }
}
