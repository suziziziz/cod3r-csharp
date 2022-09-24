using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
  public class Conversoes
  {
    public static void Executar()
    {
      int inteiro = 10;
      double quebrado = inteiro;
      Console.WriteLine(quebrado);

      double nota = 9.9;
      int notaTruncada = (int)nota;
      Console.WriteLine(notaTruncada);

      Console.WriteLine("Digite sua idade: ");
      string idadeString = Console.ReadLine() ?? "";
      int idadeInteiro = int.Parse(idadeString);
      Console.WriteLine($"Idade inserida {idadeInteiro}");

      idadeInteiro = Convert.ToInt32(idadeString);
      Console.WriteLine($"Resultado: {idadeInteiro}");

      Console.Write("Digite um número: ");
      string palavra = Console.ReadLine();
      int numero;
      int.TryParse(palavra, out numero);
      Console.WriteLine($"numero1: {numero}");

      Console.Write("Digite o segundo número: ");
      int.TryParse(Console.ReadLine(), out int numero2);
      Console.WriteLine($"numero2: {numero2}");
    }
  }
}