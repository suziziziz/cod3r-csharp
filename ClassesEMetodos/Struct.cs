using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  interface Ponto
  {
    void MoverNaDiagonal(int delta);
  }

  struct Coordenada : Ponto
  {
    public int X;
    public int Y;

    public Coordenada(int x, int y)
    {
      X = x;
      Y = y;
    }

    public void MoverNaDiagonal(int delta)
    {
      X += delta;
      Y += delta;
    }
  }

  public class Struct
  {
    public static void Executar()
    {
      Coordenada coordenadaInicial;
      coordenadaInicial.X = 2;
      coordenadaInicial.Y = 2;

      Console.WriteLine("Inicial X: {0}, Y: {1}",
        coordenadaInicial.X, coordenadaInicial.Y);

      var coordenadaFinal = new Coordenada(x: 9, y: 1);
      coordenadaFinal.MoverNaDiagonal(10);

      System.Console.WriteLine("Final X: {0}, Y: {1}",
        coordenadaFinal.X, coordenadaFinal.Y);
    }
  }
}
