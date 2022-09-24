using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
  public class Dynamics
  {
    public static void Executar()
    {
      dynamic myObj = "teste";
      myObj = 3;

      myObj++;
      Console.WriteLine(myObj);

      dynamic aluno = new System.Dynamic.ExpandoObject();
    }
  }
}
