using System;

namespace classe_aula02
{
  class Circulo
  {
    public double Raio;

    // Construtor = Tem o mesmo nome da classe e não tem retorno.
    public Circulo(double raio)
    {
      Raio = raio;
    }

    public double GetArea()
    {
      var resultado = Math.PI * Raio * Raio;

      return resultado;
    }

    public double GetPerimetro()
    {
      var resultado = 2 * Math.PI * Raio;

      return resultado;
    }
  }
}