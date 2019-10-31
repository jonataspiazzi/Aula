using System;

namespace _54
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cont = 0, max = 0, altura = 0, sexo = 0, homem = 0, mulher = 0;

            Console.WriteLine("Quantas pessoas serão análisadas?");
            max = int.Parse(Console.ReadLine());

            while (cont < max)
            {
                Console.WriteLine("Qual o sexo?");
                Console.WriteLine("1 para masculino / 2 para feminimo");
                sexo = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a altura?");
                altura = int.Parse(Console.ReadLine());

                if (sexo > 1)
                {
                    mulher = (62.1M * altura) - 44.7M; 
                    Console.WriteLine("O peso ideal é: " + mulher);
                }
                else 
                {
                    homem = (72.7M * altura) - 58;
                    Console.WriteLine("O peso ideal é: " + homem);
                }
                cont++;
            }
        }
    }
}
