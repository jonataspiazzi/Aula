using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, idade, soma;
            string nome, texto;

            cont = 0;
            soma = 0;

            while (cont < 4)
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a idade: ");
                texto = Console.ReadLine();
                idade = int.Parse(texto);

                if (idade >= 18)
                {
                    soma = soma + 1;
                }

                cont = cont + 1;
            }

            Console.WriteLine(soma + " pessoa(s) eram maiores de idade");
        }
    }
}
