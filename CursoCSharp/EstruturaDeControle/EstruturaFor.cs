using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
  public class EstruturaFor
  {
    public static void Executar()
    {
      double somatorio = 0;
      string? entrada;

      System.Console.Write("Tamanho da turma: ");
      entrada = Console.ReadLine();
      int.TryParse(entrada, out int tamanhoDaTurma);

      for (int i = 1; i <= tamanhoDaTurma; i++)
      {
        System.Console.Write($"Nota do aluno {i}: ");
        entrada = Console.ReadLine();
        double.TryParse(entrada, out double notaAtual);
        somatorio += notaAtual;
      }

      double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
      System.Console.WriteLine($"Media da turma é {media}");
    }
  }
}
