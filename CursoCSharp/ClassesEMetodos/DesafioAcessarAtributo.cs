using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class DesafioAcessarAtributo
  {
    int a = 10;

    public static void Executar()
    {
      // Acessar variável 'a' dentro do método Executar!
      DesafioAcessarAtributo desafio = new DesafioAcessarAtributo();

      Console.WriteLine(desafio.a);
    }
  }
}
