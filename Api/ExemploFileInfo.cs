using System;
using System.IO;

namespace CursoCSharp.Api
{
  public class ExemploFileInfo
  {
    public static void DeleteIfExists(params string[] caminhos)
    {
      foreach (var caminho in caminhos)
      {
        FileInfo arquivo = new FileInfo(caminho);

        if (arquivo.Exists) arquivo.Delete();
      }
    }

    public static void Executar()
    {
      var pathOrigin = @"~/cod3r_arq_origem.txt".ParseHome();
      var pathDest = @"~/cod3r_arq_destino.txt".ParseHome();
      var pathCopy = @"~/cod3r_arq_copia.txt".ParseHome();

      DeleteIfExists(pathOrigin, pathDest, pathCopy);

      using (StreamWriter sw = File.CreateText(pathOrigin))
      {
        sw.WriteLine("Arquivo original!");
      }

      FileInfo origem = new FileInfo(pathOrigin);
      Console.WriteLine(origem.Name);
      Console.WriteLine(origem.IsReadOnly);
      Console.WriteLine(origem.FullName);
      Console.WriteLine(origem.Extension);
      Console.WriteLine(origem.DirectoryName);

      origem.CopyTo(pathCopy);
      origem.MoveTo(pathDest);
    }
  }
}
