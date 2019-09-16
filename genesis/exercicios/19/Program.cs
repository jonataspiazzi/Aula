using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erro na linha 49,2 - não sei o pq deste erro.

            int cont, idade, soma, max;
            string nome,nomes, texto;

            cont = 0;
            soma = 0;
            max = 0;
            nomes = " ";

            Console.WriteLine("Quantos nomes seram analisados?");
            texto = Console.ReadLine();
            max = int.Parse(texto);
           
            while ( cont < max)
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a idade: ");
                texto = Console.ReadLine();
                idade = int.Parse(texto);

                if (idade > 20)
                {
                  soma = soma + 1;
                  nomes = nomes + nome + "  ";
                }
                else 
                {
                  
                }

                cont = cont + 1;
            }

            Console.WriteLine(nomes + ": são maiores de 20 anos");
            } 
        }
    } 