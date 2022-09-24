using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class EstruturaForEach
  {
    public static void Executar()
    {
      var palavra = "Sei lá :P";

      foreach (var letra in palavra)
      {
        System.Console.WriteLine(letra);
      }

      var alunos = new string[] {
        "Kennan", "Um maluco no pedaço", "Michael Kyle", };

      foreach (var aluno in alunos)
      {
        System.Console.WriteLine(aluno);
      }
    }
  }
}
