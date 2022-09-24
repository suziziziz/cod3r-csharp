using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class CalculadoraEstatica
  {
    // Método de instância
    public int Somar(int a, int b)
    {
      return a + b;
    }

    // Método Estático
    public static int Multiplicar(int a, int b)
    {
      return a * b;
    }
  }

  public class MetodosEstaticos
  {
    public static void Executar()
    {
      var resultado = CalculadoraEstatica.Multiplicar(2, 2);
      Console.WriteLine($"Resultado: {resultado}");

      CalculadoraEstatica calc = new CalculadoraEstatica();
      Console.WriteLine($"Resultado: {calc.Somar(2, 2)}");
    }
  }
}
