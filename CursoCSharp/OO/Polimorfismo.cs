using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
  public class Comida
  {
    public double Peso;

    public Comida(double peso) { Peso = peso; }
    public Comida() { }
  }

  public class Feijao : Comida { }
  public class Arroz : Comida { }
  public class Carne : Comida { }

  public class Pessoa
  {
    public double Peso;

    public void Comer(Comida comida) { Peso += comida.Peso; }
  }

  public class Polimorfismo
  {
    public static void Executar()
    {
      Feijao feijao = new Feijao { Peso = 0.3 };

      Arroz arroz = new Arroz { Peso = 0.25 };

      Carne carne = new Carne { Peso = 0.3 };

      Pessoa cliente = new Pessoa();
      cliente.Peso = 80.2;
      cliente.Comer(arroz);
      cliente.Comer(feijao);
      cliente.Comer(carne);

      Console.WriteLine($"Peso do cliente: {cliente.Peso}kg");
    }
  }
}
