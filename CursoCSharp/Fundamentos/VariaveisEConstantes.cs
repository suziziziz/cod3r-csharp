using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class VariaveisEConstantes
  {
    public static void Executar()
    {
      // Área da circunferência
      double raio = 4.5;
      const double PI = 3.14;

      raio = 5.5;
      // PI = 3.1415;

      double area = PI * raio * raio;
      System.Console.WriteLine("Área é " + area);


      // Tipos internos
      bool estaChovendo = false;
      System.Console.WriteLine("Está chovendo " + estaChovendo);

      byte idade = 19;
      System.Console.WriteLine("Idade " + idade);

      sbyte saldoDeGols = sbyte.MinValue;
      System.Console.WriteLine("Saldo de gols " + saldoDeGols);

      short salario = short.MaxValue;
      System.Console.WriteLine("Salario " + salario);

      int menorValorInt = int.MinValue;
      System.Console.WriteLine("Menor Valor de int " + menorValorInt);

      uint populacaoBrasileira = 207_600_000;
      System.Console.WriteLine("População brasileira " + populacaoBrasileira);

      long menorValorLong = long.MinValue;
      System.Console.WriteLine("Menor valor long " + menorValorLong);

      ulong populacaoMundial = 7_600_000_000;
      System.Console.WriteLine("População mundial " + populacaoMundial);

      float precoComputador = 1299.99f; // Usa pouca memória comparado ao duble
      System.Console.WriteLine("Preço do computador " + precoComputador);

      double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos numero reais
      System.Console.WriteLine("Valor da Apple " + valorDeMercadoDaApple);

      decimal distanciaEntreEstrelas = decimal.MaxValue;
      System.Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

      char letra = 'b';
      System.Console.WriteLine("Letra " + letra);

      string texto = "Lorem ipsum";
      System.Console.WriteLine("Texto " + texto);
    }
  }
}