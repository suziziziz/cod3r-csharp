using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
  public class Animal
  {
    public string Nome { get; set; }

    public Animal(string nome)
    {
      Nome = nome;
    }
  }

  public class Cachorro : Animal
  {
    public double Altura { get; set; }

    // `base` chama o construtor Pai
    public Cachorro(string nome) : base(nome)
    {
      System.Console.WriteLine($"Cachorro {nome}");
    }

    // `this` chama o construtor do mesmo objeto,
    // nesse caso o método `Cachorro` logo acima
    public Cachorro(string nome, double altura) : this(nome)
    {
      Altura = altura;
    }

    public override string ToString()
    {
      return $"Nome do dog: {Nome}, Altura: {Altura}cm";
    }
  }

  public class ConstrutorThis
  {
    public static void Executar()
    {
      var penelope = new Cachorro("Penélope");
      var alvin = new Cachorro("Alvin", 30);

      Console.WriteLine(penelope.ToString());
      Console.WriteLine(alvin);
    }
  }
}
