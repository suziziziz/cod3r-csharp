using System;
using System.IO;

namespace CursoCSharp.Api
{
  public class Diretorios
  {
    public static void Executar()
    {
      var newDir = @"~/cod3r_PastaCSharp".ParseHome();
      var newDirDest = @"~/cod3r_PastaCSharpDestino".ParseHome();
      var projectDir = @"~/".ParseHome();

      if (Directory.Exists(newDir))
        Directory.Delete(newDir, true);

      if (Directory.Exists(newDirDest))
        Directory.Delete(newDirDest, true);

      Directory.CreateDirectory(newDir);
      Console.WriteLine(Directory.GetCreationTime(newDir));

      Console.WriteLine("+------------+");
      Console.WriteLine("|   Pastas   |");
      Console.WriteLine("+------------+");

      var dirs = Directory.GetDirectories(projectDir);

      foreach (var dir in dirs)
        Console.WriteLine(dir);

      Console.WriteLine();
      Console.WriteLine("+--------------+");
      Console.WriteLine("|   Arquivos   |");
      Console.WriteLine("+--------------+");

      var arquivos = Directory.GetFiles(projectDir);
      foreach (var arquivo in arquivos)
        Console.WriteLine(arquivo);

      Console.WriteLine();
      Console.WriteLine("+----------+");
      Console.WriteLine("|   ROOT   |");
      Console.WriteLine("+----------+");
      Console.WriteLine(Directory.GetDirectoryRoot(newDir));

      Directory.Move(newDir, newDirDest);
    }
  }
}
