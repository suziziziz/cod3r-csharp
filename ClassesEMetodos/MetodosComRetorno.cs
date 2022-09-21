using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  class CalculadoraComum
  {
    public int Somar(int a, int b)
    {
      return a + b;
    }
    public int Somar(int a, double b)
    {
      return a + (int)b;
    }

    public int Subtrair(int a, int b)
    {
      return a - b;
    }

    public int Multiplicar(int a, int b)
    {
      return a * b;
    }

    public int Dividir(int a, int b)
    {
      return a / b;
    }
  }

  class CalculadoraCadeia
  {
    int memoria;

    public CalculadoraCadeia Somar(int a)
    {
      memoria += a;
      return this;
    }

    public CalculadoraCadeia Multiplicar(int a)
    {
      memoria *= a;
      return this;
    }

    public CalculadoraCadeia Limpar()
    {
      memoria = 0;
      return this;
    }

    public CalculadoraCadeia Imprimir()
    {
      System.Console.WriteLine(memoria);
      return this;
    }

    public int Resultado()
    {
      return memoria;
    }
  }

  public class MetodosComRetorno
  {
    public static void Executar()
    {
      CalculadoraComum calculadoraComum = new CalculadoraComum();
      int resultado;

      resultado = calculadoraComum.Somar(5, 5);
      Console.WriteLine(resultado);
      resultado = calculadoraComum.Subtrair(5, 5);
      Console.WriteLine(resultado);
      resultado = calculadoraComum.Multiplicar(5, 5);
      Console.WriteLine(resultado);
      resultado = calculadoraComum.Dividir(5, 5);
      Console.WriteLine(resultado);

      var calculadoraCadeia = new CalculadoraCadeia();
      calculadoraCadeia
        .Somar(3)
        .Multiplicar(3)
        .Imprimir()
        .Limpar()
        .Imprimir();

      resultado = calculadoraCadeia
        .Somar(5)
        .Multiplicar(5)
        .Resultado();

      System.Console.WriteLine(resultado);
    }
  }
}
