using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  public class ColecoesQueue
  {
    public static void Executar()
    {
      var fila = new Queue<string>();

      fila.Enqueue("Ronaldinho");
      fila.Enqueue("Faustão");
      fila.Enqueue("Rodrigo Faro iihaa!!");

      System.Console.WriteLine(fila.Peek());
      System.Console.WriteLine(fila.Count);
      System.Console.WriteLine(fila.Dequeue());
      System.Console.WriteLine(fila.Count);

      foreach (var pessoa in fila)
      {
        System.Console.WriteLine(pessoa);
      }

      var salada = new Queue();
      salada.Enqueue(3);
      salada.Enqueue("Item");
      salada.Enqueue(true);
      salada.Enqueue(3.1415926);

      System.Console.WriteLine(salada.Contains("item"));
      System.Console.WriteLine(salada.Contains("Item"));
    }
  }
}
