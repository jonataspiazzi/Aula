using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, idade, soma, max;
            string nome,nomesmaior, nomesmenor, idades, texto;

            cont = 0;
            soma = 0;
            max = 0;
            nomesmaior = " ";
            nomesmenor = " ";
            idades = " ";

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
                  nomesmaior = nomesmaior + nome + "  ";
                }
                else 
                {
                  idades = idades + idade + " ";
                  nomesmenor = nomesmenor + nome + " tem " + idade + " anos ";
                }

                cont = cont + 1;
            }

            Console.WriteLine(nomesmaior + ": tem idade superior a 20 anos");
            Console.WriteLine(nomesmenor);
            } 
    }
}
