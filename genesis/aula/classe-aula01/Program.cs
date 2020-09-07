using System;

namespace classe_aula01
{
  class Program
  {
    static void MainV1(string[] args)
    {
      Console.WriteLine("Digite o número de habitantes da cidade: ");
      var numeroHabitantes = int.Parse(Console.ReadLine());

      var nomes = new string[numeroHabitantes];
      var idades = new int[numeroHabitantes];

      for (var i = 0; i < numeroHabitantes; i++)
      {
        Console.WriteLine("Digite o nome: ");
        nomes[i] = Console.ReadLine();

        Console.WriteLine("Digite a idade: ");
        idades[i] = int.Parse(Console.ReadLine());
      }

      Console.WriteLine("O nomes dos habitantes maiores de 20 anos são: ");
      var contMaior40 = 0;

      for (var i = 0; i < numeroHabitantes; i++)
      {
        if (idades[i] > 20)
        {
          Console.WriteLine(nomes[i]);
        }

        if (idades[i] > 40)
        {
          contMaior40++;
        }
      }

      Console.WriteLine($"A cidade tem {contMaior40} habitantes com mais de 40 anos.");
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Digite o número de habitantes da cidade: ");
      var numeroHabitantes = int.Parse(Console.ReadLine());

      var povo = new Pessoa[numeroHabitantes];

      for (var i = 0; i < numeroHabitantes; i++)
      {
        var pessoa = new Pessoa();

        Console.WriteLine("Digite o nome: ");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Digite a idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        povo[i] = pessoa;
      }

      Console.WriteLine("O nomes dos habitantes maiores de 20 anos são: ");
      var contMaior40 = 0;

      for (var i = 0; i < numeroHabitantes; i++)
      {
        var pessoa = povo[i];

        if (pessoa.Idade > 20)
        {
          Console.WriteLine(pessoa.Idade);
        }

        if (pessoa.Idade > 40)
        {
          contMaior40++;
        }
      }

      Console.WriteLine($"A cidade tem {contMaior40} habitantes com mais de 40 anos.");
    }
  }

  class Pessoa
  {
    public string Nome;

    public int Idade;
  }
}
