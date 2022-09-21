using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public class Moto
  {
    private string Marca;
    private string Modelo;
    private uint Cilindrada;

    public Moto(string marca, string modelo, uint cilindrada)
    {
      SetMarca(marca);
      SetModelo(modelo);
      SetCilindrada(cilindrada);
    }

    public Moto() { }

    public string GetMarca()
    {
      return Marca;
    }
    public string GetModelo()
    {
      return Modelo;
    }
    public uint GetCilindrada()
    {
      return Cilindrada;
    }

    public void SetMarca(string marca)
    {
      Marca = marca;
    }
    public void SetModelo(string modelo)
    {
      Modelo = modelo;
    }
    public void SetCilindrada(uint cilindrada)
    {
      // if (cilindrada > 0)
      //   Cilindrada = cilindrada;

      // Cilindrada = Math.Abs(cilindrada);

      Cilindrada = cilindrada;
    }
  }

  public class GetSet
  {
    public static void Executar()
    {
      Moto moto = new Moto("Kawasaki", "Ninka ZX-6R", 636);

      Console.WriteLine(moto.GetMarca());
      Console.WriteLine(moto.GetModelo());
      Console.WriteLine(moto.GetCilindrada());
      Console.WriteLine();

      Moto moto2 = new Moto();

      moto2.SetMarca("Honda");
      moto2.SetModelo("CG Titan");
      moto2.SetCilindrada(150);

      Console.WriteLine(moto2.GetMarca());
      Console.WriteLine(moto2.GetModelo());
      Console.WriteLine(moto2.GetCilindrada());
    }
  }
}
