using System;
using System.IO;

namespace CursoCSharp.Api
{
  public class UsandoPath
  {
    public static void Executar()
    {
      var file = @"~/cod3r_exemplo_path_arquivo.txt".ParseHome();
      var directory = @"~/cod3r_exemplo_path_pasta".ParseHome();

      if (!File.Exists(file))
        using (StreamWriter sw = File.CreateText(file))
          sw.WriteLine("Novo arquivo");

      if (!Directory.Exists(directory))
        Directory.CreateDirectory(directory);

      Console.WriteLine(Path.GetExtension(file));
      Console.WriteLine(Path.GetFileName(file));
      Console.WriteLine(Path.GetFileNameWithoutExtension(file));
      Console.WriteLine(Path.GetDirectoryName(file));
      Console.WriteLine(Path.HasExtension(file));

      Console.WriteLine(Path.HasExtension(directory));
      Console.WriteLine(Path.GetFullPath(directory));
      Console.WriteLine(Path.GetPathRoot(directory));
    }
  }
}
