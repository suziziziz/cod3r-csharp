using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
  // Classes abstratas servem para serem herdadas
  public abstract class Celular
  {
    public abstract string Assistente();

    public string Tocar()
    {
      return "Pirilim Pirilim Pirilim! Alguém ligou pra mim!... Sou eu bola de fogo, o calor vai te matar...";
    }
  }

  public class Samsung : Celular
  {
    public override string Assistente()
    {
      return "Bixby!";
    }
  }

  public class IPhone : Celular
  {
    public override string Assistente()
    {
      return "Siri!";
    }
  }

  public class Abstract
  {
    public static void Executar()
    {
      var celulares = new List<Celular> {
        new IPhone(),
        new Samsung(),
      };

      foreach (var item in celulares)
      {
        Console.WriteLine(item.Assistente());
      }
    }
  }
}
