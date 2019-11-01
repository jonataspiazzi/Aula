using System;

namespace aula_bool_mf
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int resV, resF;

            // Abordagem 1
            /*
            Console.WriteLine("Digite um valor bool (true,false): ");
            bool a = bool.Parse(Console.ReadLine());
            if (a) {
                Console.WriteLine("Você digitou verdadeiro.");
            } else {
                Console.WriteLine("Você digitou falso.");
            }
            */

            // Abordagem 2
            /*
            Console.WriteLine("Digite um valor bool (verdadeiro,falso): ");
            aux = Console.ReadLine();
            //b = aux == "verdadeiro"; // da errado para "Verdadeiro"
            resV = string.Compare(aux, "verdadeiro", true);
            resF = string.Compare(aux, "falso", true);

            if (resV == 0) {
                Console.WriteLine("Você digitou verdadeiro.");
            } else if (resF == 0) {
                Console.WriteLine("Você digitou falso.");
            } else {
                Console.WriteLine("Você digitou um valor inválido.");
            }
             */

            // Abordagem 3
            /*
            Console.WriteLine("Digite um valor bool (masculino,feminino): ");
            aux = Console.ReadLine();
            //b = aux == "verdadeiro"; // da errado para "Verdadeiro"
            resV = string.Compare(aux, "masculino", true);
            resF = string.Compare(aux, "feminino", true);

            if (resV == 0) {
                Console.WriteLine("Você digitou masculino.");
            } else if (resF == 0) {
                Console.WriteLine("Você digitou feminino.");
            } else {
                Console.WriteLine("Você digitou um valor inválido.");
            }
            */

            // Abordagem 4
            Console.WriteLine("Digite um valor (masculino,feminino): ");
            string sexo = Console.ReadLine();
            bool masculino = string.Compare(sexo, "masculino", true) == 0;
            bool feminino = string.Compare(sexo, "feminino", true) == 0;

            if (masculino) {
                Console.WriteLine("Você digitou masculino.");
            } else if (feminino) {
                Console.WriteLine("Você digitou feminino.");
            } else {
                Console.WriteLine("Você digitou um valor inválido.");
            }
        }
    }
}
