using System;
using System.IO;

namespace CursoCSharp.Api
{
  public class ExemploDirectoryInfo
  {
    public static void Executar()
    {
      var projectDir = @"~/Desktop/Coisas/cod3r/CursoCSharp".ParseHome();
      var infoDir = new DirectoryInfo(projectDir);

      if (!infoDir.Exists) infoDir.Create();

      Console.WriteLine("+--- ARQUIVOS ---+");
      var arquivos = infoDir.GetFiles();

      foreach (var arquivo in arquivos)
      {
        Console.WriteLine(arquivo);
      }

      Console.WriteLine();
      Console.WriteLine("+--- DIRETÓRIOS ---+");
      var pastas = infoDir.GetDirectories();

      foreach (var item in pastas)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine(infoDir.CreationTime);
      Console.WriteLine(infoDir.FullName);
      Console.WriteLine(infoDir.Root);
      Console.WriteLine(infoDir.Parent);
      Console.WriteLine(infoDir.Parent?.Parent);
      Console.WriteLine(infoDir.Parent?.Parent?.Parent);
      Console.WriteLine(infoDir.Parent?.Parent?.Parent?.Parent);
    }
  }
}
