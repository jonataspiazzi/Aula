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

            Console.WriteLine("Quantos nomes seram analisados?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while ( cont < max)

            {

            Console.WriteLine("Digite a idade:");
            idade = console.ReadLine();
            Console.WriteLine("Digite o nome:");
            texto  = console.ReadLine();
            nome = int.Parse(texto);

            if ( idade > 20 )
            {
               soma = soma + 1;
               nomes = nomes + nome;
            }
            else 
            {
               Console.WriteLine("Nenhum habitante tem a idade menor que 20 anos");
            }
            cont = cont + 1;
            }
            Console.WriteLine(nomes + "São maiores de 20 anos");
            {
        }
    }
}
