using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
  public class Aluno
  {
    public string Nome;
    public int Idade;
    public double Nota;
  }

  public class LINQ01
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

      Console.WriteLine("+--- Aprovados ---+");
      var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);

      foreach (var item in aprovados)
        Console.WriteLine(item.Nome);

      Console.WriteLine("+--- CHAMADA ---+");
      var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
      foreach (var aluno in chamada)
        Console.WriteLine(aluno);

      Console.WriteLine("+--- APROVADOS (por idade) ---+");
      var alunosAprovados =
        from aluno in alunos
        where aluno.Nota >= 7
        orderby aluno.Idade
        select aluno.Nome;

      foreach (var aluno in alunosAprovados)
        Console.WriteLine(aluno);
    }
  }
}
