using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  class Carro
  {
    public string Modelo;
    public string Fabricante;
    public int Ano;

    public Carro(string modelo, string fabricante, int ano)
    {
      Modelo = modelo;
      Fabricante = fabricante;
      Ano = ano;
    }

    public Carro() { }
  }

  public class Construtores
  {
    public static void Executar()
    {
      // BAD
      var carro = new Carro();
      carro.Fabricante = "BMW";
      carro.Modelo = "325i";
      carro.Ano = 2017;
      System.Console.WriteLine($"{carro.Fabricante} {carro.Modelo} {carro.Ano}");

      // GOOD
      var carro2 = new Carro("Ka", "Ford", 2018);
      System.Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

      var carro3 = new Carro()
      {
        Modelo = "Uno",
        Fabricante = "Fiat",
        Ano = 2019,
      };
      System.Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
    }
  }
}
