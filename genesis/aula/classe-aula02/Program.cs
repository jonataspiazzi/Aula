using System;

namespace classe_aula02
{
  // Faça um algoritmo que receba N raios de N círculos e mostre a soma das áreas e dos períemtros.

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite quantos círculos: ");
      var qtd = int.Parse(Console.ReadLine());

      for (var i = 0; i < qtd; i++)
      {
        Console.WriteLine("Didite o raio do círculo: ");
        var raio = double.Parse(Console.ReadLine());

        //var c = new Circulo() { Raio = raio };

        var c = new Circulo(raio);
        //c.Raio = raio;

        var area = c.GetArea();
        var perimetro = c.GetPerimetro();

        Console.WriteLine($"A área do círculo é: {area}");
        Console.WriteLine($"O perímetro da circunferência é: {perimetro}");
      }
    }
  }
}