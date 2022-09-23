using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
  interface OperacaoBinaria
  {
    int Operacao(int a, int b);
  }

  class Soma : OperacaoBinaria
  {
    public int Operacao(int a, int b)
    {
      return a + b;
    }
  }

  class Subtracao : OperacaoBinaria
  {
    public int Operacao(int a, int b)
    {
      return a - b;
    }
  }
  class Multiplicacao : OperacaoBinaria
  {
    public int Operacao(int a, int b)
    {
      return a * b;
    }
  }

  class Calculadora
  {
    List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
      new Soma(),
      new Subtracao(),
      new Multiplicacao(),
    };

    public string ExecutarOperacoes(int a, int b)
    {
      string resultado = "";
      foreach (var item in operacoes)
      {
        resultado += $"{item.GetType().Name}: {item.Operacao(a, b)}\n";
      }
      return resultado;
    }
  }

  public class Interface
  {
    public static void Executar()
    {
      Calculadora calculadora = new Calculadora();
      string resultado = calculadora.ExecutarOperacoes(10, 5);
      Console.WriteLine(resultado);
    }
  }
}
