using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  public struct SPonto
  {
    public int X;
    public int Y;
  }
  public class CPonto
  {
    public int X;
    public int Y;
  }

  public class StructVSClasse
  {
    public static void Executar()
    {
      SPonto dot1 = new SPonto { X = 1, Y = 3 };
      SPonto cpDot1 = dot1; // Atribuição por valor
      dot1.X = 3;

      System.Console.WriteLine("Dot 1 X: {0}, Y: {1}",
        dot1.X, dot1.Y);
      System.Console.WriteLine("CP Dot 1 X: {0}, Y: {1}",
        cpDot1.X, cpDot1.Y);

      CPonto dot2 = new CPonto { X = 1, Y = 3 };
      CPonto cpDot2 = dot2; // Atribuição por referência
      dot2.X = 3;

      System.Console.WriteLine("Dot 2 X: {0}, Y: {1}",
        dot2.X, dot2.Y);
      System.Console.WriteLine("CP Dot 2 X: {0}, Y: {1}",
        cpDot2.X, cpDot2.Y);
    }
  }
}
