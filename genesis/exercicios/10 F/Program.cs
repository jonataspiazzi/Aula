using System;

namespace _10_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual modelo você deseja usar?");
            var modelo = int.Parse(Console.ReadLine());

            if (modelo == 1)
            {
                M1.Executar();
            }
            else if (modelo == 2)
            {
                M2.Executar();
            }
            else if (modelo == 3)
            {
                M3.Executar();
            }
            else if (modelo == 4)
            {
                M4.Executar();
            }
            else
            {
                Console.WriteLine("Digite um valor entre 1 e 4");
            }
        }
    }
}
