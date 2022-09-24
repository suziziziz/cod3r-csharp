using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
  public class LINQ02
  {
    public static void Executar()
    {
      var alunos = new List<Aluno> {
        new Aluno { Nome = "Michael Jackson", Idade = 30, Nota = 8.0 },
        new Aluno { Nome = "Melanie Martinez", Idade = 27, Nota = 7.8 },
        new Aluno { Nome = "Kurt Cobain", Idade = 27, Nota = 9.0 },
        new Aluno { Nome = "Amy Whinehouse", Idade = 27, Nota = 10.0 },
        new Aluno { Nome = "Michael Jackson", Idade = 35, Nota = 5.5 },
        new Aluno { Nome = "Alanis Morissette", Idade = 48, Nota = 6.5 },
      };

      var amy = alunos.Single(aluno => aluno.Nome.Equals("Amy Whinehouse"));
      Console.WriteLine($"{amy.Nome} {amy.Nota}");

      var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("Fulando"));
      if (fulano == null)
        Console.WriteLine("Alunos não existe");

      var michael = alunos.First(a => a.Nome.Equals("Michael Jackson"));
      Console.WriteLine($"{michael.Nome} {michael.Nota}");

      var sicrano = alunos.FirstOrDefault(a => a.Nome.Equals("Sicrano"));
      if (sicrano == null)
        Console.WriteLine("Alunos não existe");

      var outroMichael = alunos.Last(a => a.Nome.Equals("Michael Jackson"));
      Console.WriteLine($"{outroMichael.Nome} {outroMichael.Nota}");
      Console.WriteLine("Alunos não existe");

      var exemploSkip = alunos.Skip(1).Take(3);
      foreach (var item in exemploSkip)
        Console.WriteLine(item.Nome);

      var maiorNota = alunos.Max(a => a.Nota);
      Console.WriteLine(maiorNota);

      var menorNota = alunos.Min(a => a.Nota);
      Console.WriteLine(menorNota);

      var somaNotas = alunos.Sum(a => a.Nota);
      Console.WriteLine(somaNotas);

      var mediaNotas = alunos.Where(a => a.Nota >= 7).Average(a => a.Nota);
      Console.WriteLine(mediaNotas);
    }
  }
}
