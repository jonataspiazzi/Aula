using System;

namespace _50
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal idade = 1, sexo = 0, olho = 0, cabelo = 0, renda = 0, trintamais = 0, especialum = 0, cont = 0;

            while (idade > 0)
            {
                Console.WriteLine("Idade:");
                idade = int.Parse(Console.ReadLine());

                if (idade > 0)
                {
                    Console.WriteLine("Sexo:");
                    Console.WriteLine("1 para masculino / 2 para feminino");
                    sexo = int.Parse(Console.WriteLine());

                    Console.WriteLine("Cor dos olhos:");
                    Console.WriteLine("1 para preto / 2 para castanho / 3 para azul");
                    olho = int.Parse(Console.ReadLine());

                    Console.WriteLine("Cor do cabelo:");
                    Console.WriteLine("1 para preto / 2 para castanho / 3 para ruivo");
                    cabelo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Renda mensal:");
                    renda = int.Parse(Console.ReadLine());

                    if (idade > 30)
                    {
                        trintamais++;
                    }
                    if (sexo = 2 && olho = 1 && olho = 2 && renda > 300)
                    {
                        especialum++;
                    }
                    cont++;
                }
                Console.WriteLine("Quantidade de habitantes da região: " + cont);
                Console.WriteLine("Quantidade de pessoas com mais de 30 anos: " + trintamais);
            }
        }
    }
}
