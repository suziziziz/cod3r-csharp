using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
  public class UsandoDateTime
  {
    public static void Executar()
    {
      var dateTime = new DateTime(
        day: 11, month: 03, year: 2003);

      Console.WriteLine(dateTime.Day);
      Console.WriteLine(dateTime.Month);
      Console.WriteLine(dateTime.Year);

      var hoje = DateTime.Today;
      Console.WriteLine(hoje);

      var now = DateTime.Now;
      Console.WriteLine(now);
      Console.WriteLine(now.Hour);
      Console.WriteLine(now.Minute);
      Console.WriteLine(now.Second);
      Console.WriteLine(now.Millisecond);

      var amanha = now.AddDays(1);
      Console.WriteLine(amanha);

      var ontem = now.AddDays(-1);
      Console.WriteLine(ontem);

      Console.WriteLine(now.ToString("dd"));
      Console.WriteLine(now.ToString("d"));
      Console.WriteLine(now.ToString("D"));
      Console.WriteLine(now.ToString("g"));
      Console.WriteLine(now.ToString("G"));
      Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm"));
    }
  }
}
