using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class ColecoesArrayList
  {
    public static void Executar()
    {
      var arraylist = new ArrayList
      {
        "Palavra",
        3,
        true,
      };

      arraylist.Add(3.1415926);

      foreach (var item in arraylist)
      {
        System.Console.WriteLine($"{item} => {item.GetType()}");
      }
    }
  }
}
