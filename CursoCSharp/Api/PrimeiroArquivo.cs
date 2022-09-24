using System;
using System.IO;

namespace CursoCSharp.Api
{
  public static class ExtensionString
  {
    public static string ParseHome(this string path)
    {
      string? home = (Environment.OSVersion.Platform == PlatformID.Unix)
        ? Environment.GetEnvironmentVariable("HOME")
        : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

      return path.Replace("~", home);
    }
  }

  public class PrimeiroArquivo
  {
    public static void Executar()
    {
      var path = @"~/cod3r_primeiro_arquivo.txt".ParseHome();

      if (!File.Exists(path))
      {
        using (StreamWriter sw = File.CreateText(path))
        {
          sw.WriteLine("Esse é");
          sw.WriteLine("o nosso");
          sw.WriteLine("primeiro");
          sw.WriteLine("arquivo");
        }
      }

      using (StreamWriter sw = File.AppendText(path))
      {
        sw.WriteLine("");
        sw.WriteLine("Adicionando");
        sw.WriteLine("Mais");
        sw.WriteLine("Linhas");
      }
    }
  }
}
