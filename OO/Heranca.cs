using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
  public class Carro
  {
    protected readonly int MaxSpeed;
    int CurrentSpeed;

    public Carro(int maxSpeed)
    {
      MaxSpeed = maxSpeed;
    }

    protected int ChangeSpeed(int delta)
    {
      int newSpeed = CurrentSpeed + delta;
      CurrentSpeed = Math.Clamp(newSpeed, 0, MaxSpeed);
      return CurrentSpeed;
    }

    // `virtual` transforma o metodo em "sobreescrevivel"
    public virtual int Accelerate()
    {
      return ChangeSpeed(5);
    }

    public int Break()
    {
      return ChangeSpeed(-5);
    }
  }

  public class Uno : Carro
  {
    // Obrigatório criar um construtor caso
    // Não haja um construtor padrão base
    public Uno() : base(200) { }
  }

  public class Ferrari : Carro
  {
    public Ferrari() : base(350) { }

    public override int Accelerate()
    { return ChangeSpeed(15); }

    // O culta o método da classe Pai
    // Só funciona se o tipo for o mesmo, não do Pai
    public new int Frear()
    { return ChangeSpeed(-15); }
  }

  public class Heranca
  {
    public static void Executar()
    {
      Console.WriteLine("Uno...");
      Uno uno = new Uno();
      Console.WriteLine(uno.Accelerate());
      Console.WriteLine(uno.Accelerate());
      Console.WriteLine(uno.Break());
      Console.WriteLine(uno.Break());
      Console.WriteLine(uno.Accelerate());

      Console.WriteLine("Ferrari...");
      Ferrari ferrari = new Ferrari();
      Console.WriteLine(ferrari.Accelerate());
      Console.WriteLine(ferrari.Break());
      Console.WriteLine(ferrari.Break());
      Console.WriteLine(ferrari.Break());
      Console.WriteLine(ferrari.Accelerate());
      Console.WriteLine(ferrari.Accelerate());
      Console.WriteLine(ferrari.Accelerate());

      Console.WriteLine("Ferrari com tipo Carro...");
      Carro carro3 = new Ferrari(); // Polimorfismo
      Console.WriteLine(carro3.Accelerate());
      Console.WriteLine(carro3.Accelerate());
      Console.WriteLine(carro3.Break());
      Console.WriteLine(carro3.Break());
      Console.WriteLine(carro3.Break());
      Console.WriteLine(carro3.Break());

      Console.WriteLine("Uno com tipo Carro...");
      carro3 = new Uno(); // Polimorfismo
      Console.WriteLine(carro3.Accelerate());
      Console.WriteLine(carro3.Accelerate());
      Console.WriteLine(carro3.Break());
      Console.WriteLine(carro3.Break());
      Console.WriteLine(carro3.Break());
      Console.WriteLine(carro3.Break());
    }
  }
}
