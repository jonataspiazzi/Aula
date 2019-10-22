using System;

namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cont, max, salario, media, salarioTotal;
            string texto;
            bool sexo;

            Console.WriteLine("Quantos habitantes fizeram parte da pesquisa?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while (cont < max)
            {
                Console.WriteLine("Sexo:");
                sexo = cont.ReadLine();

                Console.WriteLine("Idade:");
                texto = Console.ReadLine();
                idade = int.Parse(texto);

                Console.WriteLine("Salário:");
                texto = Console.ReadLine();
                salario = int.Parse(texto);

                salarioTotal = salarioTotal + salario;
                media = salarioTotal / max;

                










               cont = cont + 1;
            }
            Console.WriteLine("A media dos salarios é " + media);
        }
    }
}
