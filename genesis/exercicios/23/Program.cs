using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, idade, soma;
            string nome,habitantes , texto;

            cont = 0;
            soma = 0;
            habitantes = " ";

            Console.WriteLine("Digite o nome e a idade dos habitantes um por um");
                       
            while ( cont < 10)
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a idade: ");
                texto = Console.ReadLine();
                idade = int.Parse(texto);

                if ( idade > 25 ) 
                 if ( idade < 40 ) 
                   
                {
                  soma = soma + 1;
                  habitantes = habitantes + nome + " " + idade + ",";
                  cont = cont + 1;

                }

                else 

                {
                  
                }

            }

            Console.WriteLine( habitantes );
            
        }
    }
}
