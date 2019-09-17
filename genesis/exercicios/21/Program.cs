using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
           int cont, idade, soma, maior, max;
            string nome,nomes, texto;

            cont = 0;
            soma = 0;
            max = 0;
            nomes = " ";
            maior = 0;

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
                  nomes = nomes + nome + ",";
                }
                else 
                {
                  
                }
                 if (idade >40)
                {
                  maior = maior + 1;
                }
                else 
                {
                  
                }

                cont = cont + 1;
            }

            Console.WriteLine(nomes + ": tem idade superior a 20 anos");
            Console.WriteLine(maior + ": pessoa tem idade superior a 40 anos");
        }
    }
}
