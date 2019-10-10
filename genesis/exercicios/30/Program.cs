using System;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            string comando, figura;

            figura = "*";
            comando = "imprimir";

            Console.WriteLine("Escreva o comando");
            comando = Console.ReadLine();

            if (comando = "imprimir") 
            {
                Console.WriteLine(figura);
            }
          
        }
    }
}
