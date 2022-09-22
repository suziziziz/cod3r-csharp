using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class ColecaoStack
  {
    public static void Executar()
    {
      // FILO
      var pilha = new Stack();

      pilha.Push(3);
      pilha.Push("a");
      pilha.Push(true);
      pilha.Push(3.1415926f);

      foreach (var item in pilha)
      {
        Console.Write($"{item} ");
      }

      System.Console.WriteLine($"\nPop: {pilha.Pop()}");

      foreach (var item in pilha)
      {
        Console.Write($"{item} ");
      }

      System.Console.WriteLine($"\nPop: {pilha.Peek()}");
      System.Console.WriteLine(pilha.Count);
    }
  }
}
