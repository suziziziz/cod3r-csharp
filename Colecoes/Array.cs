using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class Array
  {
    public static void Executar()
    {
      string[] alunos = new string[5];
      alunos[0] = "Chris de todo mundo odeia o Chris";
      alunos[1] = "Michael Kyle";
      alunos[2] = "Shakira";
      alunos[3] = "Lady Gaga";
      alunos[4] = "Don Corleone";

      foreach (var aluno in alunos)
      {
        Console.WriteLine(aluno);
      }

      double somatorio = 0;
      double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

      foreach (var nota in notas)
      {
        somatorio += nota;
      }

      double media = somatorio / notas.Length;
      Console.WriteLine("Média {0}", media);

      char[] letras = { 'A', 'r', 'r', 'a', 'y' };
      string palavra = new string(letras);
      Console.WriteLine(palavra);
    }
  }
}
